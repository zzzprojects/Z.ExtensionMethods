// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_ExtractHexadecimal
    {
        [TestMethod]
        public void ExtractHexadecimal()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractHexadecimal());
            Assert.AreEqual("0x2A", new StringBuilder("0x2A").ExtractHexadecimal().ToString());
            Assert.AreEqual("0x2A", new StringBuilder("0x0x2A").ExtractHexadecimal(2).ToString());
            Assert.AreEqual("0x2FUL", new StringBuilder("0x0x2FUL").ExtractHexadecimal(2, out endIndex).ToString());
            Assert.AreEqual(8, endIndex);
        }
    }
}