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
    public class System_Collections_Generic_ICollection_T_AddRangeIfNotContains
    {
        [TestMethod]
        public void AddRangeIfNotContains()
        {
            // Type
            var @this = new List<string> {"FizzExisting"};

            // Examples
            @this.AddRangeIfNotContains("Fizz"); // Add "Fizz" value
            @this.AddRangeIfNotContains("FizzExisting", "Buzz"); // Add "Buzz" value but doesn't add "Fizz"

            // Unit Test
            Assert.AreEqual(3, @this.Count);
        }
    }
}