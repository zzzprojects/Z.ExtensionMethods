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
    public class System_String_ExtractDouble
    {
        [TestMethod]
        public void ExtractDouble()
        {
            // Type

            // Exemples
            double result1 = "Fizz 123 Buzz".ExtractDouble(); // return 123;
            double result2 = "Fizz -123 Buzz".ExtractDouble(); // return -123;
            double result3 = "-Fizz 123 Buzz".ExtractDouble(); // return 123;
            double result4 = "Fizz 123.456 Buzz".ExtractDouble(); // return 123.456;
            double result5 = "Fizz -123Fizz.Buzz456 Buzz".ExtractDouble(); // return -123.456;

            // Unit Test
            Assert.AreEqual(123, result1);
            Assert.AreEqual(-123, result2);
            Assert.AreEqual(123, result3);
            Assert.AreEqual(123.456, result4);
            Assert.AreEqual(-123.456, result5);
        }
    }
}