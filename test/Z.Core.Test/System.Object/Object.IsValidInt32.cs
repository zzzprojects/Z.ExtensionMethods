using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_IsValidInt32
    {
        [TestMethod]
        public void IsValidInt32()
        {
            // Exemples
            object nullValue = null;
            bool result1 = nullValue.IsValidInt32(); // return true;
            bool result2 = "12345".IsValidInt32(); // return true;
            bool result3 = "1.32".IsValidInt32(); // return false;
            bool result4 = "ABC".IsValidInt32(); // return false;

            // Unit Test
            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
            Assert.IsFalse(result4);
        }
    }
}