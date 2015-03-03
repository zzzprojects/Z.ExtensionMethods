using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ExtractManyUInt16
    {
        [TestMethod]
        public void ExtractManyUInt16()
        {
            // Type

            // Exemples
            ushort[] result1 = "1Fizz-2Buzz".ExtractManyUInt16(); // return new [] {1, 2};
            ushort[] result2 = "12.34Fizz-0.456".ExtractManyUInt16(); // return new [] {12, 34, 0, 456};

            // Unit Test
            Assert.AreEqual((UInt16) 1, result1[0]);
            Assert.AreEqual((UInt16) 2, result1[1]);
            Assert.AreEqual((UInt16) 12, result2[0]);
            Assert.AreEqual((UInt16) 34, result2[1]);
            Assert.AreEqual((UInt16) 0, result2[2]);
            Assert.AreEqual((UInt16) 456, result2[3]);
        }
    }
}