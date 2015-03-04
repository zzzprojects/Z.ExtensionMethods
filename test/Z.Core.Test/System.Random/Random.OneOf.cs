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
    public class System_Random_OneOf
    {
        [TestMethod]
        public void OneOf()
        {
            // Type
            var @this = new Random();

            // Examples
            int value1 = @this.OneOf(1, 2, 3, 4); // return one of this value at random.
            string value2 = @this.OneOf("a", "b", "c", "d"); // return one of this value at random.
            object value3 = @this.OneOf(1, "a", DateTime.Now, new object()); // return one of this value at random.
        }
    }
}