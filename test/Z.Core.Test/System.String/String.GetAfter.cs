using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_GetAfter
    {
        [TestMethod]
        public void GetAfter()
        {
            // Type
            string @this = "Fizz";

            // Examples
            string result1 = @this.GetAfter("i"); // return "zz";
            string result2 = @this.GetAfter("a"); // return "";

            // Unit Test
            Assert.AreEqual("zz", result1);
            Assert.AreEqual("", result2);
        }
    }
}