// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_IDictionary_TKey_TValue_AddIfNotContainsKey
    {
        [TestMethod]
        public void AddIfNotContainsKey()
        {
            // Type
            var @this = new Dictionary<string, string>();

            // Examples
            @this.AddIfNotContainsKey("Fizz", "FizzBuzz"); // Add "FizzBuzz";
            @this.AddIfNotContainsKey("Fizz", () => "Buzz"); // Add Nothing;

            // Unit Test
            Assert.AreEqual("FizzBuzz", @this["Fizz"]);
        }
    }
}