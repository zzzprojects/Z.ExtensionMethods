// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ExtractDecimal
    {
        [TestMethod]
        public void ExtractDecimal()
        {
            // Type

            // Exemples
            decimal result1 = "Fizz 123 Buzz".ExtractDecimal(); // return 123;
            decimal result2 = "Fizz -123 Buzz".ExtractDecimal(); // return -123;
            decimal result3 = "-Fizz 123 Buzz".ExtractDecimal(); // return 123;
            decimal result4 = "Fizz 123.456 Buzz".ExtractDecimal(); // return 123.456;
            decimal result5 = "Fizz -123Fizz.Buzz456 Buzz".ExtractDecimal(); // return -123.456;

            // Unit Test
            Assert.AreEqual(123M, result1);
            Assert.AreEqual(-123M, result2);
            Assert.AreEqual(123M, result3);
            Assert.AreEqual(123.456M, result4);
            Assert.AreEqual(-123.456M, result5);
        }
    }
}