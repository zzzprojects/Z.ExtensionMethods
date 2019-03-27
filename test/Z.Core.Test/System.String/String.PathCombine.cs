// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_PathCombine
    {
        [TestMethod]
        public void PathCombine()
        {
            // Type
            string @this = "FizzBuzz";

            string path1 = "Fizz";
            string path2 = "Buzz";

            // Exemples
            string result = @this.PathCombine(path1, path2); // Combine path1 and path2 with the @this

            // Unit Test
            Assert.AreEqual(Path.Combine("FizzBuzz", path1, path2), result);
        }
    }
}