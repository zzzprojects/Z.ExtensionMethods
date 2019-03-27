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
    public class System_Text_StringBuilder_ExtractTriviaToken
    {
        [TestMethod]
        public void ExtractTriviaToken()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual("/*z", new StringBuilder("/*z").ExtractTriviaToken().ToString());
            Assert.AreEqual("/*z", new StringBuilder("/*/*z").ExtractTriviaToken(2).ToString());
            Assert.AreEqual("/*z*/", new StringBuilder("/**//*z*/").ExtractTriviaToken(4, out endIndex).ToString());
            Assert.AreEqual(8, endIndex);

            // Unit Test
            Assert.AreEqual("//z", new StringBuilder("//z").ExtractTriviaToken().ToString());
            Assert.AreEqual("//z", new StringBuilder("////z").ExtractTriviaToken(2).ToString());
            Assert.AreEqual("//z", new StringBuilder("////z" + Environment.NewLine + "z").ExtractTriviaToken(2, out endIndex).ToString());
            Assert.AreEqual(5, endIndex);

            // UnitTest
            Assert.AreEqual("  ", new StringBuilder("   z").ExtractTriviaToken(1, out endIndex).ToString());
            Assert.AreEqual(2, endIndex);
        }
    }
}