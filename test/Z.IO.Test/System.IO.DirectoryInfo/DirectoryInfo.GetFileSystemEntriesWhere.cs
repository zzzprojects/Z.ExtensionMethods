// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_DirectoryInfo_GetFileSystemEntriesWhere
    {
        [TestMethod]
        public void GetFileSystemEntriesWhere()
        {
            // Type
            var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "System_IO_DirectoryInfo_GetFileSystemEntriesWhere"));
            Directory.CreateDirectory(root.FullName);
            root.CreateSubdirectory("DirFizz123");
            root.CreateSubdirectory("DirBuzz123");
            var file1 = new FileInfo(Path.Combine(root.FullName, "test1.txt"));
            file1.Create();

            // Exemples
            string[] result = root.GetFileSystemEntriesWhere(x => x.Contains("DirFizz") || x.EndsWith(".txt"));

            // Unit Test
            Assert.AreEqual(2, result.Length);
        }
    }
}