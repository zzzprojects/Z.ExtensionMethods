// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_IsAlphaNumeric
    {
        [TestMethod]
        public void IsAlphaNumeric()
        {
            // Type
            string @thisAlphaNumeric = "abc123";
            string @thisNotAlphaNumeric = "abc123!<>";

            // Examples
            bool value1 = @thisAlphaNumeric.IsAlphaNumeric(); // return true;
            bool value2 = @thisNotAlphaNumeric.IsAlphaNumeric(); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}