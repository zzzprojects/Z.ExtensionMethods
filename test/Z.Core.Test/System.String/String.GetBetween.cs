// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_GetBetween
    {
        [TestMethod]
        public void GetBetween()
        {
            // Type
            string @this = "Fizz";

            // Examples
            string result1 = @this.GetBetween("F", "z"); // return "i";
            string result2 = @this.GetBetween("a", "b"); // return "";

            // Unit Test
            Assert.AreEqual("i", result1);
            Assert.AreEqual("", result2);
        }
    }
}