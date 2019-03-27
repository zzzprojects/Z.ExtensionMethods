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
    public class System_Text_StringBuilder_Substring
    {
        [TestMethod]
        public void Substring()
        {
            // Type
            var @this = new StringBuilder("0123456789");

            // Exemples
            var result1 = @this.Substring(4); // return "456789"
            var result2 = @this.Substring(4, 2); // return "45"

            // Unit Test
            Assert.AreEqual("456789", result1);
            Assert.AreEqual("45", result2);
        }
    }
}