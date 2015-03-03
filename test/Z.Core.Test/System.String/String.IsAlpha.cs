using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_IsAlpha
    {
        [TestMethod]
        public void IsAlpha()
        {
            // Type
            string @thisAlpha = "abc";
            string @thisNotAlpha = "abc123";

            // Examples
            bool value1 = @thisAlpha.IsAlpha(); // return true;
            bool value2 = @thisNotAlpha.IsAlpha(); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}