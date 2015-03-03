using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_FileInfo_ChangeExtension
    {
        [TestMethod]
        public void ChangeExtension()
        {
            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_ChangeExtension.txt"));
            var @thisNewFile = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_ChangeExtension.cs"));

            // Intialization
            using (FileStream stream = @this.Create())
            {
            }

            // Examples
            string result = @this.ChangeExtension("cs");

            // Unit Test
            Assert.AreEqual(@thisNewFile.FullName, result);
        }
    }
}