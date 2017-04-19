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
    public class System_IO_DirectoryInfo_EnsureDirectoryExists
    {
        [TestMethod]
        public void EnsureDirectoryExists()
        {
            // Type
            var @this = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EnsureDirectoryExists", "SubDirectory"));

            // Examples
            @this.EnsureDirectoryExists(); // Create the directory the first time.
            @this.EnsureDirectoryExists(); // C// Doesn't create the directory and does't throw an error.

            // Unit Test
            Assert.IsTrue(@this.Exists);
        }
    }
}