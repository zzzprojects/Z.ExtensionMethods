// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_As
    {
        [TestMethod]
        public void As()
        {
            // Type
            var intObject = (object) 13;
            var stringObject = (object) "FizzBuzz";
            var arrayObject = (object) new[] {"Fizz", "Buzz"};

            // Exemples
            var intValue = intObject.As<int>(); // return 13;
            var stringValue = stringObject.As<string>(); // return "FizzBuzz";
            int arrayCount = arrayObject.As<string[]>().Length; // return 2;

            // Unit Test
            Assert.AreEqual(13, intValue);
            Assert.AreEqual("FizzBuzz", stringValue);
            Assert.AreEqual(2, arrayCount);
        }
    }
}