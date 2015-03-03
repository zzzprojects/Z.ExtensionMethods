using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ConcatWith
    {
        [TestMethod]
        public void ConcatWith()
        {
            // Type
            string @this = "Fizz";

            // Exemples
            string result = @this.ConcatWith("Buzz", "FizzBuzz"); // return "FizzBuzzFizzBuzz";

            // Unit Test
            Assert.AreEqual("FizzBuzzFizzBuzz", result);
        }
    }
}