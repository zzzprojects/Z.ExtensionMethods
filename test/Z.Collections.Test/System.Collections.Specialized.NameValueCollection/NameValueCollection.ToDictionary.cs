// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.Collections.Specialized;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Specialized_NameValueCollection_ToDictionary
    {
        [TestMethod]
        public void ToDictionary()
        {
            // Type
            var @this = new NameValueCollection {{"Fizz", "Buzz"}};

            // Exemples
            IDictionary<string, object> result = @this.ToDictionary(); // return a Dictionary;

            // Unit Test
            Assert.AreEqual("Buzz", result["Fizz"]);
        }
    }
}