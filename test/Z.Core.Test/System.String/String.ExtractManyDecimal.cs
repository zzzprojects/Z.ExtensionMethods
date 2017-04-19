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
    public class System_String_ExtractManyDecimal
    {
        [TestMethod]
        public void ExtractManyDecimal()
        {
            // Type

            // Exemples
            decimal[] result1 = "1Fizz-2Buzz".ExtractManyDecimal(); // return new [] {1, -2};
            decimal[] result2 = "12.34Fizz-0.456".ExtractManyDecimal(); // return new [] {12.34, -0.456};

            // Unit Test
            Assert.AreEqual(1M, result1[0]);
            Assert.AreEqual(-2M, result1[1]);
            Assert.AreEqual(12.34M, result2[0]);
            Assert.AreEqual(-0.456M, result2[1]);
        }
    }
}