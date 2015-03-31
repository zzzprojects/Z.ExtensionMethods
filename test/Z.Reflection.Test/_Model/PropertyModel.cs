namespace Z.Reflection.Test
{
    public class PropertyModel<T> : AbstractPropertyModel
    {
        #region Modifier

        public static int StaticProperty { get; set; }
        public override int OverrideProperty { get; set; }
        public virtual int VirtualProperty { get; set; }

        #endregion

        #region Visibility

        internal int InternalProperty { get; set; }
        private int PrivateProperty { get; set; }
        protected int ProtectedProperty { get; set; }
        protected internal int ProtectedInternalProperty { get; set; }
        public int PublicProperty { get; set; }

        public int PublicGetterPrivateSetterProperty { get; private set; }
        public int PrivateGetterPublicSetterProperty { private get;  set; }

        #endregion

        #region Method

        public int GetterProperty
        {
            get { return _helper; }
        }

        public int SetterProperty
        {
            set { _helper = value; }
        }

        #endregion

        #region Type

        public int this[int param1, int param2, int param3]
        {
            get { return param1; }
            set { _helper = value; }
        }

        #endregion

        #region Generic

        public T GenericProperty { get; set; }

        public T this[T param1, int param2]
        {
            get { return param1; }
        }

        #endregion

        private int _helper;
        public override int AbstractProperty { get; set; }
    }

    public abstract class AbstractPropertyModel
    {
        public abstract int AbstractProperty { get; set; }
        public  virtual int OverrideProperty { get; set; }
    }
}