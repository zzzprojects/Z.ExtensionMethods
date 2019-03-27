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
    public class System_String_ReplaceWhenEquals
    {
        [TestMethod]
        public void ReplaceExact()
        {
            // Type
            string @this = "Fizz";

            // Exemples
            string result1 = @this.ReplaceWhenEquals("Fizz", "Buzz"); // return "Buzz";
            string result2 = @this.ReplaceWhenEquals("Fiz", "Buzz"); // return "Fizz";

            // Unit Test
            Assert.AreEqual("Buzz", result1);
            Assert.AreEqual("Fizz", result2);
        }
    }
}