// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Double_ToMoney
    {
        [TestMethod]
        public void ToMoney()
        {
            // Type
            double @this1 = 2.311;
            double @this2 = 2.3191;

            // Exemples
            double result1 = @this1.ToMoney(); // return 2.31;
            double result2 = @this2.ToMoney(); // return 2.32;

            // Unit Test
            Assert.AreEqual(2.31, result1);
            Assert.AreEqual(2.32, result2);
        }
    }
}