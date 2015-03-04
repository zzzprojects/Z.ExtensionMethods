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
    public class System_Object_IfNotNull
    {
        [TestMethod]
        public void IfNotNull()
        {
            // Type
            var values = new List<string> {"Fizz", "Buzz"};
            List<string> valuesNull = null;
            string actionOutput1 = null;
            string actionOutput2 = null;

            // Exemples
            string result1 = values.IfNotNull(x => x.First(), "FizzBuzz"); // return "Fizz";
            string result2 = valuesNull.IfNotNull(x => x.First(), "FizzBuzz"); // return "FizzBuzz";
            string result3 = valuesNull.IfNotNull(x => x.First(), () => "FizzBuzz"); // return "FizzBuzz"

            values.IfNotNull(x => actionOutput1 = string.Join("", values)); // = "FizzBuzz"
            valuesNull.IfNotNull(x => actionOutput2 = string.Join("", values)); // Do Nothing

            // Unit Test
            Assert.AreEqual("Fizz", result1);
            Assert.AreEqual("FizzBuzz", result2);
            Assert.AreEqual("FizzBuzz", result3);

            Assert.AreEqual("FizzBuzz", actionOutput1);
            Assert.IsNull(actionOutput2);
        }
    }
}