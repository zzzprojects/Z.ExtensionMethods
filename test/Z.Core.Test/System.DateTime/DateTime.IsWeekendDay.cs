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
    public class System_DateTime_IsWeekendDay
    {
        [TestMethod]
        public void IsWeekendDay()
        {
            // Type
            var @thisFriday = new DateTime(2013, 11, 22); // Friday
            var @thisSaturday = new DateTime(2013, 11, 23); // Saturday

            // Examples
            bool value1 = @thisFriday.IsWeekendDay(); // return false;
            bool value2 = @thisSaturday.IsWeekendDay(); // return true;

            // Unit Test
            Assert.IsFalse(value1);
            Assert.IsTrue(value2);
        }
    }
}