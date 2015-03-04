// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Char_To
    {
        [TestMethod]
        public void To()
        {
            // Type
            char @this = 'A';

            // Examples
            List<char> list = @this.To('C').ToList(); // return new [] {'a', 'b', 'c'};

            // Unit Test
            Assert.AreEqual(3, list.Count);
        }
    }
}