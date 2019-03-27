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
    public class System_String_ExtractUInt16
    {
        [TestMethod]
        public void ExtractUInt16()
        {
            // Type

            // Exemples
            ushort result1 = "Fizz 123 Buzz".ExtractUInt16(); // return 123;
            ushort result2 = "Fizz -123 Buzz".ExtractUInt16(); // return 123;
            ushort result3 = "-Fizz 123 Buzz".ExtractUInt16(); // return 123;
            ushort result4 = "Fizz 123.4 Buzz".ExtractUInt16(); // return 1234;
            ushort result5 = "Fizz -123Fizz.Buzz4 Buzz".ExtractUInt16(); // return 1234;

            // Unit Test
            Assert.AreEqual((UInt16) 123, result1);
            Assert.AreEqual((UInt16) 123, result2);
            Assert.AreEqual((UInt16) 123, result3);
            Assert.AreEqual((UInt16) 1234, result4);
            Assert.AreEqual((UInt16) 1234, result5);
        }
    }
}