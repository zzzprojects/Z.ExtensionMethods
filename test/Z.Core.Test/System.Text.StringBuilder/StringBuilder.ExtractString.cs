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
    public class System_Text_StringBuilder_ExtractString
    {
        [TestMethod]
        public void ExtractString()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractStringArobasDoubleQuote());
            Assert.AreEqual("z", new StringBuilder("@\"z\"").ExtractStringArobasDoubleQuote().ToString());
            Assert.AreEqual("z", new StringBuilder("@@\"z\"z").ExtractStringArobasDoubleQuote(1, out endIndex).ToString());
            Assert.AreEqual(5, endIndex);

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractStringArobasSingleQuote());
            Assert.AreEqual("z", new StringBuilder("@'z'").ExtractStringArobasSingleQuote().ToString());
            Assert.AreEqual("z", new StringBuilder("@@'z'z").ExtractStringArobasSingleQuote(1, out endIndex).ToString());
            Assert.AreEqual(5, endIndex);

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractStringDoubleQuote());
            Assert.AreEqual("z", new StringBuilder("\"z\"").ExtractStringDoubleQuote().ToString());
            Assert.AreEqual("z", new StringBuilder("-\"z\"z").ExtractStringDoubleQuote(1, out endIndex).ToString());
            Assert.AreEqual(4, endIndex);

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractStringSingleQuote());
            Assert.AreEqual("z", new StringBuilder("'z'").ExtractStringSingleQuote().ToString());
            Assert.AreEqual("z", new StringBuilder("-'z'z").ExtractStringSingleQuote(1, out endIndex).ToString());
            Assert.AreEqual(4, endIndex);
        }
    }
}