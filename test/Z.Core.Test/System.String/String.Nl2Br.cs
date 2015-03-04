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
    public class System_String_Nl2Br
    {
        [TestMethod]
        public void Nl2Br()
        {
            // Type
            string @this = "Fizz" + Environment.NewLine + "Buzz";

            // Exemples
            string result = @this.Nl2Br(); // return "Fizz<br />Buzz";

            // Unit Test
            Assert.AreEqual("Fizz<br />Buzz", result);
        }
    }
}