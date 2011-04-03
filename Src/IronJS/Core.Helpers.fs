﻿namespace IronJS

open System
open IronJS
open IronJS.Support.Aliases

(*
//
*)
module FSharpOperators =
  
  let (?<-) (a:'a when 'a :> CO) (b:string) (c:obj) = 
    let methodInfo = typeof<CO>.GetMethod("Put", [|typeof<string>; c.GetType()|])
    methodInfo.Invoke(a, [|b; c|]) |> ignore

  let (?) (a:'a when 'a :> CO) (name:string) : 'b =
    a.GetT<'b>(name) 

(*
//
*)
module ExtensionMethods = 

  type BoxedValue with
  
    member x.ToNumber() = x |> TC.ToNumber
    member x.ToInteger() = x |> TC.ToInteger
    member x.ToInt32() = x |> TC.ToInt32
    member x.ToUInt16() = x |> TC.ToUInt16
    member x.ToUInt32() = x |> TC.ToUInt32
    member x.ToPrimitive() = x |> TC.ToPrimitive

(*
// Function + cache that creates delegates for IronJS functions, delegates
// are cached because calling Dlr.delegateType with >16 types will generate
// incomptabile delegates for the same arguments each time it's called.
// E.g: Func<FunctionObject, CommonObject, BoxedValue>
*)

module DelegateCache =

  let private internalArgs = Seq.ofList [typeof<FO>; typeof<CO>]
  let private internalReturnType = Seq.ofList [typeof<BV>]
  let private delegateCache = new ConcurrentMutableDict<RuntimeTypeHandle list, Type>()

  let addInternalArgs (types:Type seq) = types

  let getDelegate (types:Type seq) =
    let types = Array.ofSeq types
    
    match types.Length with
    | 0 -> typeof<Function>
    | 1 -> typedefof<Function<_>>.MakeGenericType(types)
    | 2 -> typedefof<Function<_, _>>.MakeGenericType(types)
    | 3 -> typedefof<Function<_, _, _>>.MakeGenericType(types)
    | 4 -> typedefof<Function<_, _, _, _>>.MakeGenericType(types)
    | _ -> typeof<VariadicFunction>

/// Helper functions for the global scope
type GlobalScopeHelper() =
  
  ///
  static member GetGlobal(globals:CO, name:string) =
    let descriptor = globals.Find(name)
    if descriptor.HasValue 
      then descriptor.Value
      else globals.Env.RaiseReferenceError(sprintf "%s is not defined" name)

  ///
  static member GetGlobalNice(globals:CO, name:string) =
    globals.Get(name)

///
type DynamicScopeHelpers() =

  static let findObject (name:string) (dc:DynamicScope) stop =
    
    let rec find = 
      function
      | [] -> None
      | (level, o:CommonObject)::xs ->
        if level >= stop 
          then (if o.Has name then Some o else find xs)
          else None

    find dc
      
  static let findVariable (name:string) (dc:DynamicScope) stop = 
    match findObject name dc stop with
    | Some o -> name |> o.Get |> Some
    | _ -> None
    
  static member Get (name:string, dc, stop, g:CO, s:Scope, i) =
    match findObject name dc stop with
    | Some o -> o.Get name
    | _ -> if s = null then g.Get name else s.[i]
    
  static member Set (name:string, v:BV, dc, stop, g:CO, s:Scope, i) =
    match findObject name dc stop with
    | Some o -> o.Put(name, v)
    | _ -> if s = null then g.Put(name, v) else s.[i] <- v
    
  static member Call<'a when 'a :> Delegate> (name:string, args, dc, stop, g, s:Scope, i) =
    let this, func = 
      match findObject name dc stop with
      | Some o -> o, o.Get(name)
      | _ -> g, if s = null then g.Get(name) else s.[i]

    if func.IsFunction then
      let func = func.Func
      let internalArgs = [|func :> obj; this :> obj|]
      let compiled = func.MetaData.GetDelegate<'a>(func)
      compiled.DynamicInvoke(Array.append internalArgs args) |> BoxingUtils.JsBox

    else
      Error.RuntimeError.Raise(Error.cantCallClrFunctionsInWith)
      
  static member Delete (dc:DynamicScope, g:CO, name:string) =
    match findObject name dc -1 with
    | Some o -> o.Delete(name)
    | _ -> g.Delete(name)
    
  static member Push (dc:DynamicScope byref, new', level) = 
    dc <- (level, new') :: dc
      
  static member Pop (dc:DynamicScope byref) = 
    dc <- List.tail dc