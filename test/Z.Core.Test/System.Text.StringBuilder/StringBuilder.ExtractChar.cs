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