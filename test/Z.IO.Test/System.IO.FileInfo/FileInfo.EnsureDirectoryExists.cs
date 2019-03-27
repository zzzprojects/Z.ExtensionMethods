// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_FileInfo_EnsureDirectoryExists
    {
        [TestMethod]
        public void EnsureDirectoryExists()
        {
            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FileInfo_EnsureDirectoryExists", "SubDirectory1", "SubDirectory2", "CreateDirectory.txt"));

            // Examples
            @this.EnsureDirectoryExists(); // Create all subdirectories.
            @this.EnsureDirectoryExists(); // Doesn't create subdirectories or throw error.

            // Unit Test
            Assert.IsTrue(@this.Directory.Exists);
        }
    }
}