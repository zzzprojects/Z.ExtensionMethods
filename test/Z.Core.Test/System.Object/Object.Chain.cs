// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_Chain
    {
        [TestMethod]
        public void Chain()
        {
            // Type
            var @this = new List<string>();

            // Exemples
            @this.Chain(x => x.Add("Fizz"))
                .Chain(x => x.Add("Buzz"))
                .Chain(x => x.Add("FizzBuzz")); // Chain multiple action

            // Unit Test
            Assert.AreEqual(3, @this.Count);
        }
    }
}