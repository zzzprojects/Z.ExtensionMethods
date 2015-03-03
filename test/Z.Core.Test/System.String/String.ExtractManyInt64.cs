using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ExtractManyInt64
    {
        [TestMethod]
        public void ExtractManyInt64()
        {
            // Type

            // Exemples
            long[] result1 = "1Fizz-2Buzz".ExtractManyInt64(); // return new [] {1, -2};
            long[] result2 = "12.34Fizz-0.456".ExtractManyInt64(); // return new [] {12, 34, 0, 456};

            // Unit Test
            Assert.AreEqual(1, result1[0]);
            Assert.AreEqual(-2, result1[1]);
            Assert.AreEqual(12, result2[0]);
            Assert.AreEqual(34, result2[1]);
            Assert.AreEqual(0, result2[2]);
            Assert.AreEqual(456, result2[3]);
        }
    }
}