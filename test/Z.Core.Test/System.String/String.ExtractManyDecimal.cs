// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ExtractManyDecimal
    {
        [TestMethod]
        public void ExtractManyDecimal()
        {
            // Type

            // Exemples
            decimal[] result1 = "1Fizz-2Buzz".ExtractManyDecimal(); // return new [] {1, -2};
            decimal[] result2 = "12.34Fizz-0.456".ExtractManyDecimal(); // return new [] {12.34, -0.456};

            // Unit Test
            Assert.AreEqual(1M, result1[0]);
            Assert.AreEqual(-2M, result1[1]);
            Assert.AreEqual(12.34M, result2[0]);
            Assert.AreEqual(-0.456M, result2[1]);
        }
    }
}