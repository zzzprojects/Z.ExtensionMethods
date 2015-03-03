using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_FileInfo_GetDirectoryFullName
    {
        [TestMethod]
        public void GetDirectoryFullName()
        {
            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DirectoryInfo_GetDirectoryName", "CreateDirectory.txt"));

            // Examples
            string result = @this.GetDirectoryFullName(); // return @this.Directory.FullName;

            // Unit Test
            Assert.AreEqual(@this.Directory.FullName, result);
        }
    }
}