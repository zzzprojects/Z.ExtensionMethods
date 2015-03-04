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
    public class System_DateTime_Age
    {
        [TestMethod]
        public void Age()
        {
            // Type
            var @this = new DateTime(1981, 01, 01);

            // Exemples
            int result = @this.Age(); // result CurrentYear - 1981

            // Unit Test
            Assert.AreEqual(DateTime.Now.Year - 1981, result);
        }
    }
}