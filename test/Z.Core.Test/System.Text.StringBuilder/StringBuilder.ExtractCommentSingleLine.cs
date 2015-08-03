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
    public class System_Text_StringBuilder_ExtractCommentSingleLine
    {
        [TestMethod]
        public void ExtractCommentSingleLine()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractCommentSingleLine());
            Assert.AreEqual("//z", new StringBuilder("//z").ExtractCommentSingleLine().ToString());
            Assert.AreEqual("//z", new StringBuilder("////z").ExtractCommentSingleLine(2).ToString());
            Assert.AreEqual("//z", new StringBuilder("////z" + Environment.NewLine + "z").ExtractCommentSingleLine(2, out endIndex).ToString());
            Assert.AreEqual(5, endIndex);
        }
    }
}