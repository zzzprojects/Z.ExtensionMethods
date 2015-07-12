// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_IsAnagram
    {
        [TestMethod]
        public void IsAnagram()
        {
            // Type
            var @this = "abba";

            // Examples
            var value1 = @this.IsAnagram("abba"); // return true;
            var value2 = @this.IsAnagram("abab"); // return true;
            var value3 = @this.IsAnagram("aba"); // return false;
            var value4 = @this.IsAnagram(""); // return false;
            var value5 = @this.IsAnagram("aba b"); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsTrue(value2);
            Assert.IsFalse(value3);
            Assert.IsFalse(value4);
            Assert.IsFalse(value5);
        }
    }
}