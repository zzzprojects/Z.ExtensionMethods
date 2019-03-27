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
    public class TArray_ClearAll
    {
        [TestMethod]
        public void ClearAll()
        {
            // Type
            var @this = new[] {"Fizz", "Buzz"};

            // Exemples
            @this.ClearAll(); // Remove all entries.

            // Unit Test
            Assert.AreEqual(null, @this[0]);
            Assert.AreEqual(null, @this[1]);
        }
    }
}