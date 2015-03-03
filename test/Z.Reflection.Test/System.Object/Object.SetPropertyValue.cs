using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class System_Object_SetPropertyValue
    {
        [TestMethod]
        public void SetPropertyValue()
        {
            // Type
            var @this = new TestClass();

            // Exemples
            @this.SetPropertyValue("PublicProperty", 1);
            @this.SetPropertyValue("InternaStaticlProperty", 2);

            // Unit Test
            Assert.AreEqual(1, @this.PublicProperty);
            Assert.AreEqual(2, TestClass.InternaStaticlProperty);
        }

        public class TestClass
        {
            internal static int InternaStaticlProperty { get; set; }
            public int PublicProperty { get; set; }
        }
    }
}