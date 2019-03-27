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