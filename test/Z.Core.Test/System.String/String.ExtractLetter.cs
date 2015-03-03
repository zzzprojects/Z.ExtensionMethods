using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ExtractLetter
    {
        [TestMethod]
        public void ExtractLetter()
        {
            // Type
            string @this = "Fizz1Buzz2";

            // Exemples
            string result = @this.ExtractLetter(); // return "FizzBuzz";

            // Unit Test
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}