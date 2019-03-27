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
    public class System_IO_DirectoryInfo_GetFileSystemEntries
    {
        [TestMethod]
        public void GetFileSystemEntries()
        {
            // Type
            var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "System_IO_DirectoryInfo_GetFileSystemEntries"));
            Directory.CreateDirectory(root.FullName);
            root.CreateSubdirectory("DirFizz123");
            root.CreateSubdirectory("DirBuzz123");
            var file1 = new FileInfo(Path.Combine(root.FullName, "test1.txt"));
            file1.Create();

            // Exemples
            string[] result = root.GetFileSystemEntries(new[] {"DirFizz*", "*.txt"});

            // Unit Test
            Assert.AreEqual(2, result.Length);
        }
    }
}