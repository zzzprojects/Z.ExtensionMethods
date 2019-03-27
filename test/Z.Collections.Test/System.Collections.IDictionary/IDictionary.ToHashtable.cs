// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_IDictionary_ToHashtable
    {
        [TestMethod]
        public void ToHashtable()
        {
            // Type
            var @this = new Dictionary<string, string> {{"Fizz", "Buzz"}};

            // Exemples
            Hashtable result = @this.ToHashtable(); // return Hashtable;

            // Unit Test
            Assert.AreEqual("Buzz", result["Fizz"]);
        }
    }
}