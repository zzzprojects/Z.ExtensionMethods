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
    public class System_Collections_Generic_ICollection_T_AddRangeIfNotContains
    {
        [TestMethod]
        public void AddRangeIfNotContains()
        {
            // Type
            var @this = new List<string> {"FizzExisting"};

            // Examples
            @this.AddRangeIfNotContains("Fizz"); // Add "Fizz" value
            @this.AddRangeIfNotContains("FizzExisting", "Buzz"); // Add "Buzz" value but doesn't add "Fizz"

            // Unit Test
            Assert.AreEqual(3, @this.Count);
        }
    }
}