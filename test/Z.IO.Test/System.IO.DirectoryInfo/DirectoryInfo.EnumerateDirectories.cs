// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_DirectoryInfo_EnumerateDirectories
    {
        [TestMethod]
        public void EnumerateDirectories()
        {
            // Type
            var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "System_IO_DirectoryInfo_EnumerateDirectories"));
            Directory.CreateDirectory(root.FullName);
            root.CreateSubdirectory("Directory1");
            root.CreateSubdirectory("Directory2");

            // Exemples
            List<DirectoryInfo> result = root.EnumerateDirectories().ToList();

            // Unit Test
            Assert.AreEqual(2, result.Count);
        }
    }
}