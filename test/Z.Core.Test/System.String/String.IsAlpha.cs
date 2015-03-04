// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_IsAlpha
    {
        [TestMethod]
        public void IsAlpha()
        {
            // Type
            string @thisAlpha = "abc";
            string @thisNotAlpha = "abc123";

            // Examples
            bool value1 = @thisAlpha.IsAlpha(); // return true;
            bool value2 = @thisNotAlpha.IsAlpha(); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}