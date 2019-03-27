// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_Br2Nl
    {
        [TestMethod]
        public void Br2Nl()
        {
            // Type
            string @this = "Fizz<br />Buzz";

            // Exemples
            string result = @this.Br2Nl(); // return "Fizz/r/nBuzz";

            // Unit Test
            Assert.AreEqual("Fizz" + Environment.NewLine + "Buzz", result);
        }
    }
}