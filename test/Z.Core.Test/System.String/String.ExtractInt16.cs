using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ExtractInt16
    {
        [TestMethod]
        public void ExtractInt16()
        {
            // Type

            // Exemples
            short result1 = "Fizz 123 Buzz".ExtractInt16(); // return 123;
            short result2 = "Fizz -123 Buzz".ExtractInt16(); // return -123;
            short result3 = "-Fizz 123 Buzz".ExtractInt16(); // return 123;
            short result4 = "Fizz 123.4 Buzz".ExtractInt16(); // return 1234;
            short result5 = "Fizz -123Fizz.Buzz4 Buzz".ExtractInt16(); // return -1234;

            // Unit Test
            Assert.AreEqual(123, result1);
            Assert.AreEqual(-123, result2);
            Assert.AreEqual(123, result3);
            Assert.AreEqual(1234, result4);
            Assert.AreEqual(-1234, result5);
        }
    }
}