﻿using System;
using IronJS.Runtime.Js;
using IronJS.Runtime.Utils;

namespace IronJS.Runtime.Builtins
{
    class Array_prototype_slice : NativeFunction
    {
        public Array_prototype_slice(Context context)
            : base(context)
        {

        }

        public override object Call(IObj that, object[] args)
        {
            if(!HasArgs(args, 1))
                throw new NotImplementedException();

            var newArray = Context.ArrayConstructor.Construct();
            var len = JsTypeConverter.ToInt32(that.Get("length"));
            var start = JsTypeConverter.ToInt32(args[0]);

            var ks = (start < 0)
                    ? Math.Max(len + start, 0)
                    : Math.Min(start, len);

            var end = args.Length > 1 ? JsTypeConverter.ToNumber(args[1]) : len;

            var ke = (end < 0)
                     ? Math.Max(len + end, 0)
                     : Math.Min(end, len);

            var n = 0;
            IDescriptor<IObj> descriptor;

            while(ks < ke)
            {
                if (that.Get(ks, out descriptor))
                    newArray.Set(n, descriptor.Get());

                ++ks;
                ++n;
            }

            return newArray;
        }
    }
}
