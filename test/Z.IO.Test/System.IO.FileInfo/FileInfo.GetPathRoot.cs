using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_FileInfo_GetPathRoot
    {
        [TestMethod]
        public void GetPathRoot()
        {
            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DirectoryInfo_GetDirectoryName", "CreateDirectory.txt"));

            // Examples
            string result = @this.GetPathRoot();

            // Unit Test
            Assert.AreEqual(Path.GetPathRoot(@this.FullName), result);
        }
    }
}