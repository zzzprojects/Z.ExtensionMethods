using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_DirectoryInfo_EnumerateFiles
    {
        [TestMethod]
        public void EnumerateFiles()
        {
            // Type
            var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "System_IO_DirectoryInfo_EnumerateFiles"));
            Directory.CreateDirectory(root.FullName);

            var file1 = new FileInfo(Path.Combine(root.FullName, "test1.txt"));
            var file2 = new FileInfo(Path.Combine(root.FullName, "test2.txt"));
            file1.Create();
            file2.Create();

            // Exemples
            List<FileInfo> result = root.EnumerateFiles().ToList();

            // Unit Test
            Assert.AreEqual(2, result.Count);
        }
    }
}