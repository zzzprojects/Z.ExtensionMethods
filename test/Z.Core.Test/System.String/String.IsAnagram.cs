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