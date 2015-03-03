using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_DirectoryInfo_EnumerateFileSystemEntries
    {
        [TestMethod]
        public void EnumerateFileSystemEntries()
        {
            // Type
            var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "System_IO_DirectoryInfo_EnumerateFileSystemEntries"));
            Directory.CreateDirectory(root.FullName);

            var file1 = new FileInfo(Path.Combine(root.FullName, "test1.txt"));
            file1.Create();
            root.CreateSubdirectory("test2");

            // Exemples
            List<string> result = root.EnumerateFileSystemEntries().ToList();

            // Unit Test
            Assert.AreEqual(2, result.Count);
        }
    }
}