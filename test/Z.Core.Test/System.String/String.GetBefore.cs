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
    public class System_String_GetBefore
    {
        [TestMethod]
        public void GetBefore()
        {
            // Type
            string @this = "Fizz";

            // Examples
            string result1 = @this.GetBefore("i"); // return "F";
            string result2 = @this.GetBefore("a"); // return "";

            // Unit Test
            Assert.AreEqual("F", result1);
            Assert.AreEqual("", result2);
        }
    }
}