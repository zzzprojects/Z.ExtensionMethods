using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Compression.Test
{
    [TestClass]
    public class System_IO_FileInfo_ExtractGZip
    {
        [TestMethod]
        public void ExtractGZip()
        {
            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_ExtractGZip.txt"));
            var output = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_ExtractGZip.gz"));
            var outputExtract = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_ExtractGZip_Example.txt"));

            // Intialization
            using (FileStream stream = @this.Create())
            {
            }

            // Examples
            @this.CreateGZip(output);
            output.ExtractGZipToDirectory(outputExtract);

            // Unit Test
            Assert.IsTrue(outputExtract.Exists);
        }
    }
}