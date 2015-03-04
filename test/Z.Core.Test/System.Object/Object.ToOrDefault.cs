// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_ToOrDefault
    {
        [TestMethod]
        public void ToOrDefault()
        {
            // Type
            object intValue = "1";
            object invalidValue = "Fizz";

            // Exemples
            var result1 = intValue.ToOrDefault<int>(); // return 1;
            var result2 = invalidValue.ToOrDefault<int>(); // return 0;
            int result3 = invalidValue.ToOrDefault(3); // return 3;
            int result4 = invalidValue.ToOrDefault(() => 4); // return 4;

            // Unit Test
            Assert.AreEqual(1, result1);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(3, result3);
            Assert.AreEqual(4, result4);
        }
    }
}