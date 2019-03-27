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
    public class System_Text_StringBuilder_ExtractToken
    {
        [TestMethod]
        public void ExtractToken()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractToken());
            Assert.AreEqual("123.4LU", new StringBuilder("123.4LU foreach").ExtractToken().ToString());
            Assert.AreEqual("for", new StringBuilder("for foreach").ExtractToken().ToString());
            Assert.AreEqual("custom", new StringBuilder("custom foreach").ExtractToken().ToString());
            Assert.AreEqual("+=", new StringBuilder("z += 2").ExtractToken(2, out endIndex).ToString());
            Assert.AreEqual(3, endIndex);
        }
    }
}