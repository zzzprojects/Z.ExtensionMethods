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
    public class System_String_StripHtml
    {
        [TestMethod]
        public void StripHtml()
        {
            // Exemples
            string result1 = "FizzBuzz".StripHtml(); // return "FizzBuzz";
            string result2 = "Fizz<span>Buzz</span>".StripHtml(); // return "FizzBuzz";
            string result3 = "Fizz<span id='toto>' onclick=\"<test></test>\" escapeSingleQuote='\\\'>' escapeDoubleQuote=\"\\\">\">Buzz</span>".StripHtml(); // return "FizzBuzz";

            // Unit Test
            Assert.AreEqual("FizzBuzz", result1);
            Assert.AreEqual("FizzBuzz", result2);
            Assert.AreEqual("FizzBuzz", result3);
        }
    }
}