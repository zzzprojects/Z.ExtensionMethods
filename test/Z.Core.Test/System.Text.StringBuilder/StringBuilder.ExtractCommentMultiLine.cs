// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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