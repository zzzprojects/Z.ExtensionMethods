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
    public class System_IO_DirectoryInfo_GetFilesWhere
    {
        [TestMethod]
        public void GetFilesWhere()
        {
            // Type
            var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "System_IO_DirectoryInfo_GetFilesWhere"));
            Directory.CreateDirectory(root.FullName);

            var file1 = new FileInfo(Path.Combine(root.FullName, "test.txt"));
            var file2 = new FileInfo(Path.Combine(root.FullName, "test.cs"));
            var file3 = new FileInfo(Path.Combine(root.FullName, "test.asp"));
            file1.Create();
            file2.Create();
            file3.Create();

            // Exemples
            FileInfo[] result = root.GetFilesWhere(x => x.Extension == ".txt" || x.Extension == ".cs");

            // Unit Test
            Assert.AreEqual(2, result.Length);
        }
    }
}