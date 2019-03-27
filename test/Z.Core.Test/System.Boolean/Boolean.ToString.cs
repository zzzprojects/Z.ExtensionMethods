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
    public class System_Boolean_ToString
    {
        [TestMethod]
        public void ToString()
        {
            // Type
            bool @thisTrue = true;
            bool @thisFalse = false;

            // Exemples
            string result1 = @thisTrue.ToString("Fizz", "Buzz"); // return "Fizz";
            string result2 = @thisFalse.ToString("Fizz", "Buzz"); // return "Buzz";

            // Unit Test
            Assert.AreEqual("Fizz", result1);
            Assert.AreEqual("Buzz", result2);
        }
    }
}