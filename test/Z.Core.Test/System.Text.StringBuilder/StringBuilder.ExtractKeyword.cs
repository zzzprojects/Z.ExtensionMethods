// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_ExtractKeyword
    {
        [TestMethod]
        public void ExtractKeyword()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractKeyword());
            Assert.AreEqual(null, new StringBuilder("1.1").ExtractKeyword());
            Assert.AreEqual(null, new StringBuilder("@1a").ExtractKeyword());
            Assert.AreEqual("for", new StringBuilder("for foreach").ExtractKeyword().ToString());
            Assert.AreEqual("@for", new StringBuilder("zzz @for foreach").ExtractKeyword(4, out endIndex).ToString());
            Assert.AreEqual(7, endIndex);
        }
    }
}