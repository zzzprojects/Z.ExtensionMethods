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
    public class System_String_IsAlphaNumeric
    {
        [TestMethod]
        public void IsAlphaNumeric()
        {
            // Type
            string @thisAlphaNumeric = "abc123";
            string @thisNotAlphaNumeric = "abc123!<>";

            // Examples
            bool value1 = @thisAlphaNumeric.IsAlphaNumeric(); // return true;
            bool value2 = @thisNotAlphaNumeric.IsAlphaNumeric(); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}