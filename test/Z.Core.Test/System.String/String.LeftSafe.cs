using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_LeftSafe
    {
        [TestMethod]
        public void LeftSafe()
        {
            // Type
            string @this = "Fizz";

            // Examples
            string result1 = @this.LeftSafe(2); // return "Fi";
            string result2 = @this.LeftSafe(int.MaxValue); // return "Fizz";

            // Unit Test
            Assert.AreEqual("Fi", result1);
            Assert.AreEqual("Fizz", result2);
        }
    }
}