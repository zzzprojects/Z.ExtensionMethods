using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_RemoveNumber
    {
        [TestMethod]
        public void RemoveNumber()
        {
            // Type
            string @this = "Fizz1Buzz2";

            // Exemples
            string result = @this.RemoveNumber(); // return "FizzBuzz";

            // Unit Test
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}