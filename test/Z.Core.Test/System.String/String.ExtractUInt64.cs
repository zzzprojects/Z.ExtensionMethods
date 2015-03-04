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