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
    public class System_Collections_Generic_IDictionary_String_Object_ToExpando
    {
        [TestMethod]
        public void ToExpando()
        {
            // Type
            var @this = new Dictionary<string, object> {{"Fizz", "Buzz"}};

            // Exemples
            dynamic result = @this.ToExpando(); // return an expando object;

            // Unit Test
            Assert.AreEqual("Buzz", result.Fizz);
        }
    }
}