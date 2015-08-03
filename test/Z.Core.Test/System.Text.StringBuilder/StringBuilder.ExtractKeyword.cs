// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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