﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using IronJS.Extensions;
using IronJS.Runtime;
using IronJS.Runtime.Binders;
using IronJS.Runtime.Js;
using IronJS.Runtime.Utils;
using Microsoft.Scripting.Utils;

namespace IronJS.Compiler
{
    using AstUtils = Microsoft.Scripting.Ast.Utils;
    using Et = System.Linq.Expressions.Expression;

    class LabelScope
    {
        internal readonly LabelScope Parent;
        internal readonly string Name;
        internal readonly bool IsLoop;
        readonly LabelTarget _break;
        readonly LabelTarget _continue;

        internal LabelScope(LabelScope parent, string name = null, bool isDefault = true)
        {
            Name = name;
            IsLoop = IsLoop;
            Parent = parent;

            _break = Et.Label(typeof(object), "#break");
            _continue = Et.Label(typeof(object), "#continue");
        }

        internal LabelTarget Break(string name = null)
        {
            var scope = this;

            while (scope != null)
            {
                if (scope.IsLoop && name == null)
                    return scope._break;

                if (scope.Name == name)
                    return scope._break;

                scope = scope.Parent;
            }

            if(name == null)
                throw new CompilerError("Not inside a loop");

            throw new CompilerError("No label named '" + name + "' found");
        }

        internal LabelTarget Continue(string name = null)
        {
            var scope = this;

            while (scope != null)
            {
                if (scope.IsLoop)
                {
                    if (name == null)
                        return scope._continue;

                    if (name == scope.Name)
                        return scope._continue;
                }

                scope = scope.Parent;
            }

            if(name == null)
                throw new CompilerError("Not inside a loop");

            throw new CompilerError("No loop labelled '" + name + "' found (continue only works with loops)");
        }

        internal LabelScope Enter(string name, bool isLoop)
        {
            return new LabelScope(this, name, isLoop);
        }
    }
}