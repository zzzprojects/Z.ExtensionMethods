// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_ToStringSafe
    {
        [TestMethod]
        public void ToStringSafe()
        {
            // Type
            int @thisValue = 1;
            string @thisNull = null;

            // Exemples
            string result1 = @thisValue.ToStringSafe(); // return "1";
            string result2 = @thisNull.ToStringSafe(); // return "";

            // Unit Test
            Assert.AreEqual(result1, "1");
            Assert.AreEqual(result2, "");
        }
    }
}