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