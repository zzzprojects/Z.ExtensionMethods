using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_FileInfo_IsPathRooted
    {
        [TestMethod]
        public void IsPathRooted()
        {
            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DirectoryInfo_GetDirectoryName", "CreateDirectory.txt"));

            // Examples
            bool result = @this.IsPathRooted();

            // Unit Test
            Assert.AreEqual(Path.IsPathRooted(@this.FullName), result);
        }
    }
}