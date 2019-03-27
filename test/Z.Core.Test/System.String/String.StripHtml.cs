// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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