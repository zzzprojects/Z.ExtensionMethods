// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_IsPalindrome
    {
        [TestMethod]
        public void IsPalindrome()
        {

            // Examples
            bool value1 = "abba".IsPalindrome();  // return true;
            bool value2 = "ab ba".IsPalindrome();  // return true;
            bool value3 = "ab'ba".IsPalindrome();   // return true;
            bool value4 = "abca".IsPalindrome();      // return false;
            bool value5 = "ab b ab".IsPalindrome(); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsTrue(value2);
            Assert.IsTrue(value3);
            Assert.IsFalse(value4);
            Assert.IsFalse(value5);
        }
    }
}
