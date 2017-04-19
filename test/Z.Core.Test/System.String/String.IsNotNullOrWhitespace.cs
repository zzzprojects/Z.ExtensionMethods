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
    public class System_String_IsNotNullOrWhitespace
    {
        [TestMethod]
        public void IsNotNullOrEmpty()
        {
            // Type
            string @thisNull = null;

            // Examples
            bool value1 = "  Z".IsNotNullOrWhiteSpace(); // return true;
            bool value2 = @thisNull.IsNotNullOrWhiteSpace(); // return false;
            bool value3 = "".IsNotNullOrWhiteSpace(); // return false;
            bool value4 = "   ".IsNotNullOrWhiteSpace(); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
            Assert.IsFalse(value3);
            Assert.IsFalse(value4);
        }
    }
}