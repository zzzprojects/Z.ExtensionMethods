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
    public class System_String_Nl2Br
    {
        [TestMethod]
        public void Nl2Br()
        {
            // Type
            string @this = "Fizz" + Environment.NewLine + "Buzz";

            // Exemples
            string result = @this.Nl2Br(); // return "Fizz<br />Buzz";

            // Unit Test
            Assert.AreEqual("Fizz<br />Buzz", result);
        }
    }
}