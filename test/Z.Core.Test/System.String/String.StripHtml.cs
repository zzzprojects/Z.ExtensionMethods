// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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