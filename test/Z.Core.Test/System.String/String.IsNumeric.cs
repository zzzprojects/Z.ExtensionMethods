using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_IsNumeric
    {
        [TestMethod]
        public void IsNumeric()
        {
            // Type
            string @thisNumeric = "123";
            string @thisNotNumeric = "abc123";

            // Examples
            bool value1 = @thisNumeric.IsNumeric(); // return true;
            bool value2 = @thisNotNumeric.IsNumeric(); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}