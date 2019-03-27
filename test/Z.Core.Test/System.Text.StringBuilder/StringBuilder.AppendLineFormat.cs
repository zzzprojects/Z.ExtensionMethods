// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_AppendLineFormat
    {
        [TestMethod]
        public void AppendLineFormat()
        {
            // Type
            var @this = new StringBuilder();

            // Exemples
            @this.AppendLineFormat("{0}{1}", "Fizz", "Buzz"); // return "FizzBuzz";

            // Unit Test
            Assert.AreEqual("FizzBuzz" + Environment.NewLine, @this.ToString());
        }
    }
}