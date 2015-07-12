// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_AppendLineIf
    {
        [TestMethod]
        public void AppendLineIf()
        {
            // Type
            var @this = new StringBuilder();

            // Exemples
            @this.AppendLineIf(x => x.Contains("F"), "Fizz", "Buzz"); // return "FizzBuzz";

            // Unit Test
            Assert.AreEqual("Fizz", @this.ToString());
        }
    }
}