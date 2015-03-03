using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_Between
    {
        [TestMethod]
        public void Between()
        {
            // Type
            int @this = 3;

            // Exemples
            bool result1 = @this.Between(1, 4); // return true;
            bool result2 = @this.Between(1, 3); // return false;

            // Unit Test
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}