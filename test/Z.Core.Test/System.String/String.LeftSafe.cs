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