// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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