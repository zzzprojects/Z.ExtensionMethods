// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Boolean_IfTrue
    {
        [TestMethod]
        public void IfTrue()
        {
            // Variables
            string value1 = "";
            string value2 = "";

            // Type
            const bool conditionTrue = true;
            const bool conditionFalse = false;

            // Examples
            conditionTrue.IfTrue(() => value1 = "FizzBuzz"); // value1 = "FizzBuzz";
            conditionFalse.IfTrue(() => value2 = "FizzBuzz"); // value2 = "";

            // Unit Test
            Assert.AreEqual("FizzBuzz", value1);
            Assert.AreEqual("", value2);
        }
    }
}