using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Boolean_ToString
    {
        [TestMethod]
        public void ToString()
        {
            // Type
            bool @thisTrue = true;
            bool @thisFalse = false;

            // Exemples
            string result1 = @thisTrue.ToString("Fizz", "Buzz"); // return "Fizz";
            string result2 = @thisFalse.ToString("Fizz", "Buzz"); // return "Buzz";

            // Unit Test
            Assert.AreEqual("Fizz", result1);
            Assert.AreEqual("Buzz", result2);
        }
    }
}