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
    public class System_IO_FileInfo_Rename
    {
        [TestMethod]
        public void Rename()
        {
            // Type
            var workingDirectory = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "System_IO_FileInfo_Rename"));
            workingDirectory.EnsureDirectoryExists();
            workingDirectory.Clear();

            var @this = new FileInfo(Path.Combine(workingDirectory.FullName, "Examples_System_IO_FileInfo_Rename.txt"));
            var @thisNewFile = new FileInfo(Path.Combine(workingDirectory.FullName, "Examples_System_IO_FileInfo_Rename2.cs"));
            bool result1 = @thisNewFile.Exists;

            // Intialization
            using (FileStream stream = @this.Create())
            {
            }

            // Examples
            @this.Rename("Examples_System_IO_FileInfo_Rename2.cs");

            // Unit Test
            @thisNewFile = new FileInfo(Path.Combine(workingDirectory.FullName, "Examples_System_IO_FileInfo_Rename2.cs"));
            bool result2 = @thisNewFile.Exists;

            Assert.IsFalse(result1);
            Assert.IsTrue(result2);
        }
    }
}