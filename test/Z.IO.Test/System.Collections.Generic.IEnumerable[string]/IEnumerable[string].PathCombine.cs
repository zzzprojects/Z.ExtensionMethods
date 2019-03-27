// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_Collections_Generic_IEnumerable_string_PathCombine
    {
        [TestMethod]
        public void PathCombine()
        {
            // Type
            var @this = new List<string> {"c:\\", "Fizz", "Buzz.txt"};

            // Exemples
            string result = @this.PathCombine(); // return "c:\Fizz\Buzz.txt"

            // Unit Test
            Assert.AreEqual(@"c:\Fizz\Buzz.txt", result);
        }
    }
}