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
    public class System_String_ExtractUInt64
    {
        [TestMethod]
        public void ExtractUInt64()
        {
            // Type

            // Exemples
            ulong result1 = "Fizz 123 Buzz".ExtractUInt64(); // return 123;
            ulong result2 = "Fizz -123 Buzz".ExtractUInt64(); // return 123;
            ulong result3 = "-Fizz 123 Buzz".ExtractUInt64(); // return 123;
            ulong result4 = "Fizz 123.456 Buzz".ExtractUInt64(); // return 123456;
            ulong result5 = "Fizz -123Fizz.Buzz456 Buzz".ExtractUInt64(); // return 123456;

            // Unit Test
            Assert.AreEqual((UInt64) 123, result1);
            Assert.AreEqual((UInt64) 123, result2);
            Assert.AreEqual((UInt64) 123, result3);
            Assert.AreEqual((UInt64) 123456, result4);
            Assert.AreEqual((UInt64) 123456, result5);
        }
    }
}