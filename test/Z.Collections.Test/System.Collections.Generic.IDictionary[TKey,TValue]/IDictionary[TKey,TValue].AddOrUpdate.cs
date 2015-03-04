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
    public class System_Collections_Generic_IDictionary_TKey_TValue_AddOrUpdate
    {
        [TestMethod]
        public void AddOrUpdate()
        {
            // Type
            var @this = new Dictionary<string, string>();

            // Examples
            string value1 = @this.AddOrUpdate("Fizz", "Buzz"); // return "Buzz";
            string value2 = @this.AddOrUpdate("Fizz", "Buzz2"); // return "Buzz2";

            // Unit Test
            Assert.AreEqual("Buzz", value1);
            Assert.AreEqual("Buzz2", value2);
        }
    }
}