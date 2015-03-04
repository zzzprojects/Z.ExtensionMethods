// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_ToInt32OrDefault
    {
        [TestMethod]
        public void ToInt32OrDefault()
        {
            // Type
            string @thisValid = "32";
            string @thisInvalid = "FizzBuzz";

            // Exemples
            int result1 = @thisValid.ToInt32OrDefault(); // return 32;
            int result2 = @thisInvalid.ToInt32OrDefault(); // return 0;
            int result3 = @thisInvalid.ToInt32OrDefault(-1); // return -1;
            int result4 = @thisInvalid.ToInt32OrDefault(() => -2); // return -2;

            // Unit Test
            Assert.AreEqual(32, result1);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(-1, result3);
            Assert.AreEqual(-2, result4);
        }
    }
}