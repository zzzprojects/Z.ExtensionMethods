using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_DirectoryInfo_GetSize
    {
        [TestMethod]
        public void GetSize()
        {
            // Type
            var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "System_IO_DirectoryInfo_GetSize"));
            Directory.CreateDirectory(root.FullName);

            var file1 = new FileInfo(Path.Combine(root.FullName, "test.txt"));
            var file2 = new FileInfo(Path.Combine(root.FullName, "test.cs"));
            var file3 = new FileInfo(Path.Combine(root.FullName, "test.asp"));
            file1.Create();
            file2.Create();
            file3.Create();

            // Exemples
            long result = root.GetSize(); // return directory size;
        }
    }
}