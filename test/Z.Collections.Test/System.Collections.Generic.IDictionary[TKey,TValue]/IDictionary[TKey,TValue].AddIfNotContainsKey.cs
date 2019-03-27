// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_IDictionary_TKey_TValue_AddIfNotContainsKey
    {
        [TestMethod]
        public void AddIfNotContainsKey()
        {
            // Type
            var @this = new Dictionary<string, string>();

            // Examples
            @this.AddIfNotContainsKey("Fizz", "FizzBuzz"); // Add "FizzBuzz";
            @this.AddIfNotContainsKey("Fizz", () => "Buzz"); // Add Nothing;

            // Unit Test
            Assert.AreEqual("FizzBuzz", @this["Fizz"]);
        }
    }
}