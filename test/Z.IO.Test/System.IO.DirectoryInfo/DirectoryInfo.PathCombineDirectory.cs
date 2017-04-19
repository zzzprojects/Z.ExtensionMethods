// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_DirectoryInfo_PathCombineDirectory
    {
        [TestMethod]
        public void PathCombine()
        {
            // Type
            var @this = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            string path1 = "Fizz";
            string path2 = "Buzz";

            // Exemples
            DirectoryInfo result = @this.PathCombineDirectory(path1, path2); // Combine path1 and path2 with the DirectoryInfo

            // Unit Test
            var expected = new DirectoryInfo(Path.Combine(@this.FullName, path1, path2));
            Assert.AreEqual(expected.FullName, result.FullName);
        }
    }
}