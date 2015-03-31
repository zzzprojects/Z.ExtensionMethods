using System;

namespace Z.Reflection.Test
{
    public class FieldModel<T>
    {
        #region Modifier

        public const int ConstField = 1;
        public static int StaticField;
        public readonly int ReadOnlyField = 1;
        public volatile int VolatileField = 1;
        public event EventHandler EventField;

        #endregion

        #region Visibility

        internal int InternalField;
        protected internal int ProtectedInternalField;
        private int PrivateField;
        protected int ProtectedField;
        public int PublicField;

        #endregion

        #region Generic

        public T GenericField;

        #endregion
    }
}