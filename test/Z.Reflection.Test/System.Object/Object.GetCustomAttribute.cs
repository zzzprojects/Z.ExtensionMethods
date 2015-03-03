using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class System_Object_GetCustomAttribute
    {
        [TestMethod]
        public void GetCustomAttribute()
        {
            // Type
            var @this = new TestObject();

            // Exemples
            var result1 = @this.GetCustomAttribute<System.ComponentModel.DescriptionAttribute>(true); // return "Test Description";
            object result2 = @this.GetCustomAttribute(typeof(System.ComponentModel.DescriptionAttribute), true); // return "Test Description";

            // Unit Test
            Assert.AreEqual("Test Description", result1.Description);
            Assert.AreEqual("Test Description", ((System.ComponentModel.DescriptionAttribute)result2).Description);
        }

        [System.ComponentModel.Description("Test Description")]
        public class TestObject
        {
        }
    }
}