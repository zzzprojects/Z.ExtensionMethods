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
    public class System_String_ContainsAny
    {
        [TestMethod]
        public void ContainsAny()
        {
            // Type
            string @this = "Fizz";

            // Examples
            bool value1 = @this.ContainsAny("F", "Buzz"); // value = ";
            bool value2 = @this.ContainsAny("Bizz", "Buzz"); // value = ";
            bool value3 = @this.ContainsAny(StringComparison.InvariantCultureIgnoreCase, "f", "Buzz"); // value = ";
            bool value4 = @this.ContainsAny(StringComparison.InvariantCulture, "f", "Buzz"); // value = ";

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
            Assert.IsTrue(value3);
            Assert.IsFalse(value4);
        }
    }
}