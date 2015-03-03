using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_Stream_ReadToEnd
    {
        [TestMethod]
        public void ReadToEnd()
        {
            var fileInfo = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_ReadToEnd.txt"));

            // Examples
            string value = "";
            using (FileStream @this = fileInfo.Create())
            {
                @this.WriteByte(0);
                @this.Position = 0;
                value = @this.ReadToEnd(); // return "\0";
            }

            // Unit Test
            Assert.AreEqual("\0", value);
        }
    }
}