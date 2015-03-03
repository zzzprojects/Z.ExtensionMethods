using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_IsNotNullOrEmpty
    {
        [TestMethod]
        public void IsNotNullOrEmpty()
        {
            // Type
            string @thisValue = "Fizz";
            string @thisNull = null;

            // Examples
            bool value1 = @thisValue.IsNotNullOrEmpty(); // return true;
            bool value2 = @thisNull.IsNotNullOrEmpty(); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}