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
    public class System_String_ExtractUInt32
    {
        [TestMethod]
        public void ExtractUInt32()
        {
            // Type

            // Exemples
            uint result1 = "Fizz 123 Buzz".ExtractUInt32(); // return 123;
            uint result2 = "Fizz -123 Buzz".ExtractUInt32(); // return 123;
            uint result3 = "-Fizz 123 Buzz".ExtractUInt32(); // return 123;
            uint result4 = "Fizz 123.456 Buzz".ExtractUInt32(); // return 123456;
            uint result5 = "Fizz -123Fizz.Buzz456 Buzz".ExtractUInt32(); // return 123456;

            // Unit Test
            Assert.AreEqual((UInt32) 123, result1);
            Assert.AreEqual((UInt32) 123, result2);
            Assert.AreEqual((UInt32) 123, result3);
            Assert.AreEqual((UInt32) 123456, result4);
            Assert.AreEqual((UInt32) 123456, result5);
        }
    }
}