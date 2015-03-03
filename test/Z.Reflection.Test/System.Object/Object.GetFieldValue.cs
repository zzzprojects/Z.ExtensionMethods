using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class System_Object_GetFieldValue
    {
        [TestMethod]
        public void GetFieldValue()
        {
            // Type
            var @this = new TestClass();

            // Exemples
            object result1 = @this.GetFieldValue("PublicField"); // return 1;
            object result2 = @this.GetFieldValue("InternaStaticlField"); // return 2;

            // Unit Test
            Assert.AreEqual(1, result1);
            Assert.AreEqual(2, result2);
        }

        public class TestClass
        {
            internal static int InternaStaticlField = 2;
            public int PublicField = 1;
        }
    }
}