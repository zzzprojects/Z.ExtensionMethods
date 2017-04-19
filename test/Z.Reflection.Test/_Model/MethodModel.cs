// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace Z.Reflection.Test
{
    public class MethodModel<T> : AbstractMethodModel
    {
        public class Toto<T2>
        {
            
        }
        #region Modifier

        public static int StaticMethod()
        {
            return 1;
        }

        public override int OverrideMethod()
        {
            return 1;
        }

        public virtual int VirtualMethod()
        {
            return 1;
        }

        #endregion

        #region Visibility

        public int PublicMethod()
        {
            return 1;
        }

        private int PrivateMethod()
        {
            return 1;
        }

        internal int InternalMethod()
        {
            return 1;
        }

        protected int ProtectedMethod()
        {
            return 1;
        }

        protected internal int ProtectedInternalMethod()
        {
            return 1;
        }

        #endregion

        #region Parameter

        public int OutParameterMethod(out int i)
        {
            i = 1;
            return 1;
        }

        public int RefParameterMethod(ref int i)
        {
            return 1;
        }

        public int ParamsParameterMethod(params int[] i)
        {
            return 1;
        }

        public int OptionalParameterMethod(int i = 1)
        {
            return 1;
        }

        #endregion

        #region ParameterModifier

        public int InParameterModifierMethod([In] int i)
        {
            return 1;
        }

        public int OutParameterModifierMethod([Out] int i)
        {
            i = 1;
            return 1;
        }

        public int OptionalParameterModifierMethod([Optional] int i)
        {
            return 1;
        }

        #endregion

        #region GenericType

        public T GenericTypeMethod(T i)
        {
            return i;
        }

        #endregion

        #region GenericMethod

        public T1 GenericMethod<T1, T2>(T1 i, T2 i2)
        {
            return i;
        }

        #endregion

        public override int AbstractMethod()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class AbstractMethodModel
    {
        public abstract int AbstractMethod();
        public abstract int OverrideMethod();
    }

    public static class ExtensionMethodModel
    {
        public static int ExtensionParameterMethod(this int i)
        {
            return 1;
        }
    }
}