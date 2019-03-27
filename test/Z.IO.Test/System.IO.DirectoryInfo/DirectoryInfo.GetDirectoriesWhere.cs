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
    public class System_IO_DirectoryInfo_GetDirectoriesWhere
    {
        [TestMethod]
        public void GetDirectoriesWhere()
        {
            // Type
            var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "System_IO_DirectoryInfo_GetDirectories"));
            Directory.CreateDirectory(root.FullName);
            root.CreateSubdirectory("DirFizz123");
            root.CreateSubdirectory("DirBuzz123");
            root.CreateSubdirectory("DirNotFound123");

            // Exemples
            DirectoryInfo[] result = root.GetDirectoriesWhere(x => x.Name.StartsWith("DirFizz") || x.Name.StartsWith("DirBuzz"));

            // Unit Test
            Assert.AreEqual(2, result.Length);
        }
    }
}