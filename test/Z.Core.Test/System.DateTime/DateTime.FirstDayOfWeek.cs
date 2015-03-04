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
    public class System_DateTime_FirstDayOfWeek
    {
        [TestMethod]
        public void FirstDayOfWeek()
        {
            // Type
            var @this = new DateTime(2014, 04, 16);

            // Exemples
            DateTime result = @this.FirstDayOfWeek(); // result = "2013/04/13";

            // Unit Test
            Assert.AreEqual(new DateTime(2014, 04, 13), result);
        }
    }
}