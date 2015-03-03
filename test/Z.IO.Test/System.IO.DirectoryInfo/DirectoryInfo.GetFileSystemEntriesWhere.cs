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