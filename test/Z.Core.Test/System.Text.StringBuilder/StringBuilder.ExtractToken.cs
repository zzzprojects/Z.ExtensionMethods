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