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