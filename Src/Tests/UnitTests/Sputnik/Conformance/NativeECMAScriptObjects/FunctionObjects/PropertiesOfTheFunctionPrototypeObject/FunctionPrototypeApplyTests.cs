// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.FunctionObjects.PropertiesOfTheFunctionPrototypeObject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FunctionPrototypeApplyTests : SputnikTestFixture
    {
        public FunctionPrototypeApplyTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.3_Function_Objects\15.3.4_Properties_of_the_Function_Prototype_Object\15.3.4.3_Function.prototype.apply")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("The apply method performs a function call using the [[Call]] property of the object. If the object does not have a [[Call]] property, a TypeError exception is thrown")]
        public void S15_3_4_3_A1_T1()
        {
            RunFile(@"S15.3.4.3_A1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("The apply method performs a function call using the [[Call]] property of the object. If the object does not have a [[Call]] property, a TypeError exception is thrown")]
        public void S15_3_4_3_A1_T2()
        {
            RunFile(@"S15.3.4.3_A1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("The Function.prototype.apply.length property has the attribute ReadOnly")]
        public void S15_3_4_3_A10()
        {
            RunFile(@"S15.3.4.3_A10.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("The Function.prototype.apply.length property has the attribute DontEnum")]
        public void S15_3_4_3_A11()
        {
            RunFile(@"S15.3.4.3_A11.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [TestCategory("ECMA 13.2")]
        [Description("Function.prototype.apply has not prototype property")]
        public void S15_3_4_3_A12()
        {
            RunFile(@"S15.3.4.3_A12.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("The length property of the apply method is 2")]
        public void S15_3_4_3_A2_T1()
        {
            RunFile(@"S15.3.4.3_A2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("The length property of the apply method is 2")]
        public void S15_3_4_3_A2_T2()
        {
            RunFile(@"S15.3.4.3_A2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is null or undefined, the called function is passed the global object as the this value")]
        public void S15_3_4_3_A3_T1()
        {
            RunFile(@"S15.3.4.3_A3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is null or undefined, the called function is passed the global object as the this value")]
        public void S15_3_4_3_A3_T10()
        {
            RunFile(@"S15.3.4.3_A3_T10.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is null or undefined, the called function is passed the global object as the this value")]
        public void S15_3_4_3_A3_T2()
        {
            RunFile(@"S15.3.4.3_A3_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is null or undefined, the called function is passed the global object as the this value")]
        public void S15_3_4_3_A3_T3()
        {
            RunFile(@"S15.3.4.3_A3_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is null or undefined, the called function is passed the global object as the this value")]
        public void S15_3_4_3_A3_T4()
        {
            RunFile(@"S15.3.4.3_A3_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is null or undefined, the called function is passed the global object as the this value")]
        public void S15_3_4_3_A3_T5()
        {
            RunFile(@"S15.3.4.3_A3_T5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is null or undefined, the called function is passed the global object as the this value")]
        public void S15_3_4_3_A3_T6()
        {
            RunFile(@"S15.3.4.3_A3_T6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is null or undefined, the called function is passed the global object as the this value")]
        public void S15_3_4_3_A3_T7()
        {
            RunFile(@"S15.3.4.3_A3_T7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is null or undefined, the called function is passed the global object as the this value")]
        public void S15_3_4_3_A3_T8()
        {
            RunFile(@"S15.3.4.3_A3_T8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is null or undefined, the called function is passed the global object as the this value")]
        public void S15_3_4_3_A3_T9()
        {
            RunFile(@"S15.3.4.3_A3_T9.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is not null(defined) the called function is passed ToObject(thisArg) as the this value")]
        public void S15_3_4_3_A5_T1()
        {
            RunFile(@"S15.3.4.3_A5_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is not null(defined) the called function is passed ToObject(thisArg) as the this value")]
        public void S15_3_4_3_A5_T2()
        {
            RunFile(@"S15.3.4.3_A5_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is not null(defined) the called function is passed ToObject(thisArg) as the this value")]
        public void S15_3_4_3_A5_T3()
        {
            RunFile(@"S15.3.4.3_A5_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is not null(defined) the called function is passed ToObject(thisArg) as the this value")]
        public void S15_3_4_3_A5_T4()
        {
            RunFile(@"S15.3.4.3_A5_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is not null(defined) the called function is passed ToObject(thisArg) as the this value")]
        public void S15_3_4_3_A5_T5()
        {
            RunFile(@"S15.3.4.3_A5_T5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is not null(defined) the called function is passed ToObject(thisArg) as the this value")]
        public void S15_3_4_3_A5_T6()
        {
            RunFile(@"S15.3.4.3_A5_T6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is not null(defined) the called function is passed ToObject(thisArg) as the this value")]
        public void S15_3_4_3_A5_T7()
        {
            RunFile(@"S15.3.4.3_A5_T7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If thisArg is not null(defined) the called function is passed ToObject(thisArg) as the this value")]
        public void S15_3_4_3_A5_T8()
        {
            RunFile(@"S15.3.4.3_A5_T8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("if argArray is neither an array nor an arguments object (see 10.1.8), a TypeError exception is thrown")]
        public void S15_3_4_3_A6_T1()
        {
            RunFile(@"S15.3.4.3_A6_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("if argArray is neither an array nor an arguments object (see 10.1.8), a TypeError exception is thrown")]
        public void S15_3_4_3_A6_T2()
        {
            RunFile(@"S15.3.4.3_A6_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("if argArray is neither an array nor an arguments object (see 10.1.8), a TypeError exception is thrown")]
        public void S15_3_4_3_A6_T3()
        {
            RunFile(@"S15.3.4.3_A6_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("if argArray is neither an array nor an arguments object (see 10.1.8), a TypeError exception is thrown")]
        public void S15_3_4_3_A6_T4()
        {
            RunFile(@"S15.3.4.3_A6_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If argArray is either an array or an arguments object, the function is passed the (ToUint32(argArray.length)) arguments argArray[0], argArray[1],...,argArray[ToUint32(argArray.length)-1]")]
        public void S15_3_4_3_A7_T1()
        {
            RunFile(@"S15.3.4.3_A7_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If argArray is either an array or an arguments object, the function is passed the (ToUint32(argArray.length)) arguments argArray[0], argArray[1],...,argArray[ToUint32(argArray.length)-1]")]
        public void S15_3_4_3_A7_T10()
        {
            RunFile(@"S15.3.4.3_A7_T10.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If argArray is either an array or an arguments object, the function is passed the (ToUint32(argArray.length)) arguments argArray[0], argArray[1],...,argArray[ToUint32(argArray.length)-1]")]
        public void S15_3_4_3_A7_T2()
        {
            RunFile(@"S15.3.4.3_A7_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If argArray is either an array or an arguments object, the function is passed the (ToUint32(argArray.length)) arguments argArray[0], argArray[1],...,argArray[ToUint32(argArray.length)-1]")]
        public void S15_3_4_3_A7_T3()
        {
            RunFile(@"S15.3.4.3_A7_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If argArray is either an array or an arguments object, the function is passed the (ToUint32(argArray.length)) arguments argArray[0], argArray[1],...,argArray[ToUint32(argArray.length)-1]")]
        public void S15_3_4_3_A7_T4()
        {
            RunFile(@"S15.3.4.3_A7_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If argArray is either an array or an arguments object, the function is passed the (ToUint32(argArray.length)) arguments argArray[0], argArray[1],...,argArray[ToUint32(argArray.length)-1]")]
        public void S15_3_4_3_A7_T5()
        {
            RunFile(@"S15.3.4.3_A7_T5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If argArray is either an array or an arguments object, the function is passed the (ToUint32(argArray.length)) arguments argArray[0], argArray[1],...,argArray[ToUint32(argArray.length)-1]")]
        public void S15_3_4_3_A7_T6()
        {
            RunFile(@"S15.3.4.3_A7_T6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If argArray is either an array or an arguments object, the function is passed the (ToUint32(argArray.length)) arguments argArray[0], argArray[1],...,argArray[ToUint32(argArray.length)-1]")]
        public void S15_3_4_3_A7_T7()
        {
            RunFile(@"S15.3.4.3_A7_T7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If argArray is either an array or an arguments object, the function is passed the (ToUint32(argArray.length)) arguments argArray[0], argArray[1],...,argArray[ToUint32(argArray.length)-1]")]
        public void S15_3_4_3_A7_T8()
        {
            RunFile(@"S15.3.4.3_A7_T8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("If argArray is either an array or an arguments object, the function is passed the (ToUint32(argArray.length)) arguments argArray[0], argArray[1],...,argArray[ToUint32(argArray.length)-1]")]
        public void S15_3_4_3_A7_T9()
        {
            RunFile(@"S15.3.4.3_A7_T9.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("Function.prototype.apply can`t be used as [[create]] caller")]
        public void S15_3_4_3_A8_T1()
        {
            RunFile(@"S15.3.4.3_A8_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("Function.prototype.apply can`t be used as [[create]] caller")]
        public void S15_3_4_3_A8_T2()
        {
            RunFile(@"S15.3.4.3_A8_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("Function.prototype.apply can`t be used as [[create]] caller")]
        public void S15_3_4_3_A8_T3()
        {
            RunFile(@"S15.3.4.3_A8_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("Function.prototype.apply can`t be used as [[create]] caller")]
        public void S15_3_4_3_A8_T4()
        {
            RunFile(@"S15.3.4.3_A8_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("Function.prototype.apply can`t be used as [[create]] caller")]
        public void S15_3_4_3_A8_T5()
        {
            RunFile(@"S15.3.4.3_A8_T5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("Function.prototype.apply can`t be used as [[create]] caller")]
        public void S15_3_4_3_A8_T6()
        {
            RunFile(@"S15.3.4.3_A8_T6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.3.4.3")]
        [Description("The Function.prototype.apply.length property has the attribute DontDelete")]
        public void S15_3_4_3_A9()
        {
            RunFile(@"S15.3.4.3_A9.js");
        }
    }
}