using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ExtractUInt64
    {
        [TestMethod]
        public void ExtractUInt64()
        {
            // Type

            // Exemples
            ulong result1 = "Fizz 123 Buzz".ExtractUInt64(); // return 123;
            ulong result2 = "Fizz -123 Buzz".ExtractUInt64(); // return 123;
            ulong result3 = "-Fizz 123 Buzz".ExtractUInt64(); // return 123;
            ulong result4 = "Fizz 123.456 Buzz".ExtractUInt64(); // return 123456;
            ulong result5 = "Fizz -123Fizz.Buzz456 Buzz".ExtractUInt64(); // return 123456;

            // Unit Test
            Assert.AreEqual((UInt64) 123, result1);
            Assert.AreEqual((UInt64) 123, result2);
            Assert.AreEqual((UInt64) 123, result3);
            Assert.AreEqual((UInt64) 123456, result4);
            Assert.AreEqual((UInt64) 123456, result5);
        }
    }
}