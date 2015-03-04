// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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