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
    public class System_Text_StringBuilder_ExtractChar
    {
        [TestMethod]
        public void ExtractChar()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual('a', new StringBuilder("'a'").ExtractChar());
            Assert.AreEqual('\'', new StringBuilder("'\''").ExtractChar());
            Assert.AreEqual('\'', new StringBuilder("z'\''").ExtractChar(1, out endIndex));
            Assert.AreEqual(3, endIndex);

            try
            {
                new StringBuilder("'").ExtractChar();
                throw new Exception("invalid!");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid char at position: 0", ex.Message);
            }
        }
    }
}