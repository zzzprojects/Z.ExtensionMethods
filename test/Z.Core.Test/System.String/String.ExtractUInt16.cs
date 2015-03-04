// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ExtractUInt16
    {
        [TestMethod]
        public void ExtractUInt16()
        {
            // Type

            // Exemples
            ushort result1 = "Fizz 123 Buzz".ExtractUInt16(); // return 123;
            ushort result2 = "Fizz -123 Buzz".ExtractUInt16(); // return 123;
            ushort result3 = "-Fizz 123 Buzz".ExtractUInt16(); // return 123;
            ushort result4 = "Fizz 123.4 Buzz".ExtractUInt16(); // return 1234;
            ushort result5 = "Fizz -123Fizz.Buzz4 Buzz".ExtractUInt16(); // return 1234;

            // Unit Test
            Assert.AreEqual((UInt16) 123, result1);
            Assert.AreEqual((UInt16) 123, result2);
            Assert.AreEqual((UInt16) 123, result3);
            Assert.AreEqual((UInt16) 1234, result4);
            Assert.AreEqual((UInt16) 1234, result5);
        }
    }
}