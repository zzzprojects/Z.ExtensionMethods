// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_AppendJoin
    {
        [TestMethod]
        public void AppendLineFormat()
        {
            var list = new List<string> {"Fizz", "Buzz"};

            // Type
            var @this = new StringBuilder();


            // Exemples
            @this.AppendJoin(",", list); // return "Fizz,Buzz";

            // Unit Test
            Assert.AreEqual("Fizz,Buzz", @this.ToString());
        }
    }
}