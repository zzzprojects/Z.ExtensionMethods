// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_IEnumerable_T_ForEach
    {
        [TestMethod]
        public void ForEach()
        {
            string result1 = "";
            string result2 = "";
            int sum2 = 0;
            // Type
            IEnumerable<string> @this = new List<string> {"zA", "zB", "C"}.AsEnumerable();

            // Exemples
            @this.ForEach(s => result1 += s);
            @this.ForEach((s, i) =>
            {
                result2 += s;
                sum2 += i;
            });

            // Unit Test
            Assert.AreEqual("zAzBC", result1);

            Assert.AreEqual("zAzBC", result2);
            Assert.AreEqual(3, sum2);
        }
    }
}