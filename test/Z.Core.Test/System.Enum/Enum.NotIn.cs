// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Enum_NotIn
    {
        [TestMethod]
        public void NotIn()
        {
            // Type
            var @this = Environment.SpecialFolder.Desktop;

            // Exemples
            bool result1 = @this.NotIn(Environment.SpecialFolder.Desktop, Environment.SpecialFolder.DesktopDirectory); // return false;
            bool result2 = @this.NotIn(Environment.SpecialFolder.DesktopDirectory); // return true;

            // Unit Test
            Assert.IsFalse(result1);
            Assert.IsTrue(result2);
        }
    }
}