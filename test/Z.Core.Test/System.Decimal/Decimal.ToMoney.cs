// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Decimal_ToMoney
    {
        [TestMethod]
        public void ToMoney()
        {
            // Type
            decimal @this1 = 2.311M;
            decimal @this2 = 2.3191M;

            // Exemples
            decimal result1 = @this1.ToMoney(); // return 2.31;
            decimal result2 = @this2.ToMoney(); // return 2.32;

            // Unit Test
            Assert.AreEqual(2.31M, result1);
            Assert.AreEqual(2.32M, result2);
        }
    }
}