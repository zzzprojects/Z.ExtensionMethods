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
    public class System_Collections_Generic_IDictionary_TKey_TValue_AddOrUpdate
    {
        [TestMethod]
        public void AddOrUpdate()
        {
            // Type
            var @this = new Dictionary<string, string>();

            // Examples
            string value1 = @this.AddOrUpdate("Fizz", "Buzz"); // return "Buzz";
            string value2 = @this.AddOrUpdate("Fizz", "Buzz2"); // return "Buzz2";

            // Unit Test
            Assert.AreEqual("Buzz", value1);
            Assert.AreEqual("Buzz2", value2);
        }
    }
}