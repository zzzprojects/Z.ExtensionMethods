using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ExtractManyUInt32
    {
        [TestMethod]
        public void ExtractManyUInt32()
        {
            // Type

            // Exemples
            uint[] result1 = "1Fizz-2Buzz".ExtractManyUInt32(); // return new [] {1, 2};
            uint[] result2 = "12.34Fizz-0.456".ExtractManyUInt32(); // return new [] {12, 34, 0, 456};

            // Unit Test
            Assert.AreEqual((UInt32) 1, result1[0]);
            Assert.AreEqual((UInt32) 2, result1[1]);
            Assert.AreEqual((UInt32) 12, result2[0]);
            Assert.AreEqual((UInt32) 34, result2[1]);
            Assert.AreEqual((UInt32) 0, result2[2]);
            Assert.AreEqual((UInt32) 456, result2[3]);
        }
    }
}