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
    public class System_Object_To
    {
        [TestMethod]
        public void To()
        {
            string nullValue = null;
            string value = "1";
            object dbNullValue = DBNull.Value;

            // Exemples
            var result1 = value.To<int>(); // return 1;
            var result2 = value.To<int?>(); // return 1;
            var result3 = nullValue.To<int?>(); // return null;
            var result4 = dbNullValue.To<int?>(); // return null;

            // Unit Test
            Assert.AreEqual(1, result1);
            Assert.AreEqual(1, result2.Value);
            Assert.IsFalse(result3.HasValue);
            Assert.IsFalse(result4.HasValue);
        }
    }
}