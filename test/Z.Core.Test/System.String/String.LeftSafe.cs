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
    public class System_String_LeftSafe
    {
        [TestMethod]
        public void LeftSafe()
        {
            // Type
            string @this = "Fizz";

            // Examples
            string result1 = @this.LeftSafe(2); // return "Fi";
            string result2 = @this.LeftSafe(int.MaxValue); // return "Fizz";

            // Unit Test
            Assert.AreEqual("Fi", result1);
            Assert.AreEqual("Fizz", result2);
        }
    }
}