using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_DirectoryInfo_GetDirectories
    {
        [TestMethod]
        public void GetDirectories()
        {
            // Type
            var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "System_IO_DirectoryInfo_GetDirectories"));
            Directory.CreateDirectory(root.FullName);
            root.CreateSubdirectory("DirFizz123");
            root.CreateSubdirectory("DirBuzz123");
            root.CreateSubdirectory("DirNotFound123");

            // Exemples
            DirectoryInfo[] result = root.GetDirectories(new[] {"DirFizz*", "DirBuzz*"});

            // Unit Test
            Assert.AreEqual(2, result.Length);
        }
    }
}