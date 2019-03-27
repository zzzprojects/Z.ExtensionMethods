// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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