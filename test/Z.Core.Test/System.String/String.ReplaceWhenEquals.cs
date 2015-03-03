using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ReplaceWhenEquals
    {
        [TestMethod]
        public void ReplaceExact()
        {
            // Type
            string @this = "Fizz";

            // Exemples
            string result1 = @this.ReplaceWhenEquals("Fizz", "Buzz"); // return "Buzz";
            string result2 = @this.ReplaceWhenEquals("Fiz", "Buzz"); // return "Fizz";

            // Unit Test
            Assert.AreEqual("Buzz", result1);
            Assert.AreEqual("Fizz", result2);
        }
    }
}