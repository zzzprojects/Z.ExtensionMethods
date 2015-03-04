// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ExtractManyDouble
    {
        [TestMethod]
        public void ExtractManyDouble()
        {
            // Type

            // Exemples
            double[] result1 = "1Fizz-2Buzz".ExtractManyDouble(); // return new [] {1, -2};
            double[] result2 = "12.34Fizz-0.456".ExtractManyDouble(); // return new [] {12.34, -0.456};

            // Unit Test
            Assert.AreEqual(1, result1[0]);
            Assert.AreEqual(-2, result1[1]);
            Assert.AreEqual(12.34, result2[0]);
            Assert.AreEqual(-0.456, result2[1]);
        }
    }
}