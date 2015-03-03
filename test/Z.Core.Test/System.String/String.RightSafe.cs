using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_RightSafe
    {
        [TestMethod]
        public void RightSafe()
        {
            // Type
            string @this = "Fizz";

            // Examples
            string result1 = @this.RightSafe(2); // return "zz";
            string result2 = @this.RightSafe(int.MaxValue); // return "Fizz";

            // Unit Test
            Assert.AreEqual("zz", result1);
            Assert.AreEqual("Fizz", result2);
        }
    }
}