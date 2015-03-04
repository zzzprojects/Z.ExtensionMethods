// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Boolean_ToBinary
    {
        [TestMethod]
        public void ToBinary()
        {
            // Type
            bool @thisTrue = true;
            bool @thisFalse = false;

            // Exemples
            byte result1 = @thisTrue.ToBinary(); // return 1;
            byte result2 = @thisFalse.ToBinary(); // return 0;

            // Unit Test
            Assert.AreEqual(1, result1);
            Assert.AreEqual(0, result2);
        }
    }
}