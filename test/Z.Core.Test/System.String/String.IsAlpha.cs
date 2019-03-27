// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_IsAlpha
    {
        [TestMethod]
        public void IsAlpha()
        {
            // Type
            string @thisAlpha = "abc";
            string @thisNotAlpha = "abc123";

            // Examples
            bool value1 = @thisAlpha.IsAlpha(); // return true;
            bool value2 = @thisNotAlpha.IsAlpha(); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}