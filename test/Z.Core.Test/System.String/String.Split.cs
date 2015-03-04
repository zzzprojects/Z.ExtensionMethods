// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_Split
    {
        [TestMethod]
        public void Split()
        {
            // Type
            string @this = "FizzBuzz";

            // Examples
            string[] value = @this.Split("B"); // return new[] {"Fizz", "uzz"}

            // Unit Test
            Assert.AreEqual("Fizz", value[0]);
            Assert.AreEqual("uzz", value[1]);
        }
    }
}