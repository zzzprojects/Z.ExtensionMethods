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
    public class System_Text_StringBuilder_Substring
    {
        [TestMethod]
        public void Substring()
        {
            // Type
            var @this = new StringBuilder("0123456789");

            // Exemples
            var result1 = @this.Substring(4); // return "456789"
            var result2 = @this.Substring(4, 2); // return "45"

            // Unit Test
            Assert.AreEqual("456789", result1);
            Assert.AreEqual("45", result2);
        }
    }
}