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
    public class System_String_ExtractLetter
    {
        [TestMethod]
        public void ExtractLetter()
        {
            // Type
            string @this = "Fizz1Buzz2";

            // Exemples
            string result = @this.ExtractLetter(); // return "FizzBuzz";

            // Unit Test
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}