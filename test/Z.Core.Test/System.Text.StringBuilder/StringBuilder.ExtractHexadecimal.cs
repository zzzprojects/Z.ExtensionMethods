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