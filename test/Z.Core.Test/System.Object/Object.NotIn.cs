using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_NotIn
    {
        [TestMethod]
        public void NotIn()
        {
            // Type
            string @this = "a";

            // Examples
            bool value1 = @this.NotIn("1", "2", "3"); // return true
            bool value2 = @this.NotIn("a", "1", "2", "3"); // return false

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}