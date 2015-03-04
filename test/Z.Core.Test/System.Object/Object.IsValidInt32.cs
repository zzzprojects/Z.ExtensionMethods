// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_IsValidInt32
    {
        [TestMethod]
        public void IsValidInt32()
        {
            // Exemples
            object nullValue = null;
            bool result1 = nullValue.IsValidInt32(); // return true;
            bool result2 = "12345".IsValidInt32(); // return true;
            bool result3 = "1.32".IsValidInt32(); // return false;
            bool result4 = "ABC".IsValidInt32(); // return false;

            // Unit Test
            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
            Assert.IsFalse(result4);
        }
    }
}