// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_ExtractCommentMultiLine
    {
        [TestMethod]
        public void ExtractCommentMultiLine()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractCommentMultiLine());
            Assert.AreEqual("/*z", new StringBuilder("/*z").ExtractCommentMultiLine().ToString());
            Assert.AreEqual("/*z", new StringBuilder("/*/*z").ExtractCommentMultiLine(2).ToString());
            Assert.AreEqual("/*z*/", new StringBuilder("/**//*z*/").ExtractCommentMultiLine(4, out endIndex).ToString());
            Assert.AreEqual(8, endIndex);
        }
    }
}