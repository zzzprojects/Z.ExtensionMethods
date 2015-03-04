// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_IsNotNullOrEmpty
    {
        [TestMethod]
        public void IsNotNullOrEmpty()
        {
            // Type
            var @this = new List<string>();

            // Examples
            bool value1 = @this.IsNotNullOrEmpty(); // return false;

            @this.Add("Fizz");
            bool value2 = @this.IsNotNullOrEmpty(); // return true;

            @this = null;
            bool value3 = @this.IsNotNullOrEmpty(); // return false;

            // Unit Test
            Assert.IsFalse(value1);
            Assert.IsTrue(value2);
            Assert.IsFalse(value3);
        }
    }
}