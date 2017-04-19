// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Runtime.InteropServices;

namespace Z.Reflection.Test
{
    public class PublicConstructorModel
    {
    }

    public class PrivateConstructorModel
    {
        private PrivateConstructorModel()
        {
        }
    }

    public class InternalConstructorModel
    {
        internal InternalConstructorModel()
        {
        }
    }

    public class OutParameterConstructorModel
    {
        public OutParameterConstructorModel(out int i)
        {
            i = 0;
        }
    }

    public class RefParameterConstructorModel
    {
        public RefParameterConstructorModel(ref int i)
        {
        }
    }

    public class ParamsParameterConstructorModel
    {
        public ParamsParameterConstructorModel(params int[] i)
        {
        }
    }

    public class OptionalParameterConstructorModel
    {
        public OptionalParameterConstructorModel(int i = 0)
        {
        }
    }

    public class InParameterModifierConstructorModel
    {
        public InParameterModifierConstructorModel([In] int i)
        {
        }
    }

    public class OutParameterModifierConstructorModel
    {
        public OutParameterModifierConstructorModel([Out] int i)
        {
        }
    }

    public class OptionalParameterModifierConstructorModel
    {
        public OptionalParameterModifierConstructorModel([Optional] int i)
        {
        }
    }

    public class GenericTypeConstructorModel<T>
    {
        public GenericTypeConstructorModel(T i)
        {
        }
    }
}