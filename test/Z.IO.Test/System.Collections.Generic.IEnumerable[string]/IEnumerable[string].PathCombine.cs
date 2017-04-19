// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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