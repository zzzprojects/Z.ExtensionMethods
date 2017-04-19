// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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
