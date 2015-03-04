// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Serialization.Test
{
    [TestClass]
    public class System_Object_SerializeJson
    {
        [TestMethod]
        public void SerializeJson()
        {
            // Type
            var @this = new List<string> {"Fizz", "Buzz"};

            // Examples
            string result = @this.SerializeJson(); // Serialize the object into a string.

            // Unit Test
            var result2 = result.DeserializeJson<List<string>>();
            Assert.AreEqual(2, result2.Count);
            Assert.AreEqual("Fizz", result2[0]);
            Assert.AreEqual("Buzz", result2[1]);
        }
    }
}