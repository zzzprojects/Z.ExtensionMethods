using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_IsDefault
    {
        [TestMethod]
        public void IsDefault()
        {
            // Type
            int intDefault = 0;
            int intNotDefault = 1;

            // Exemples
            bool result1 = intDefault.IsDefault(); // return true;
            bool result2 = intNotDefault.IsDefault(); // return false;

            // Unit Test
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}