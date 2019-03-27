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
    public class System_String_ExtractManyUInt64
    {
        [TestMethod]
        public void ExtractManyUInt64()
        {
            // Type

            // Exemples
            ulong[] result1 = "1Fizz-2Buzz".ExtractManyUInt64(); // return new [] {1, 2};
            ulong[] result2 = "12.34Fizz-0.456".ExtractManyUInt64(); // return new [] {12, 34, 0, 456};

            // Unit Test
            Assert.AreEqual((UInt64) 1, result1[0]);
            Assert.AreEqual((UInt64) 2, result1[1]);
            Assert.AreEqual((UInt64) 12, result2[0]);
            Assert.AreEqual((UInt64) 34, result2[1]);
            Assert.AreEqual((UInt64) 0, result2[2]);
            Assert.AreEqual((UInt64) 456, result2[3]);
        }
    }
}