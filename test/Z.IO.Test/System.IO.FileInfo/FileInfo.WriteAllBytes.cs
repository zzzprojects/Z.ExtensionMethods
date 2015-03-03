using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_FileInfo_WriteAllBytes
    {
        [TestMethod]
        public void WriteAllBytes()
        {
            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_WriteAllBytes.txt"));

            // Intialization
            using (FileStream stream = @this.Create())
            {
            }

            // Examples
            @this.WriteAllBytes(Encoding.Default.GetBytes("Fizz" + Environment.NewLine + "Buzz"));

            // Unit Test
            Assert.AreEqual("Fizz" + Environment.NewLine + "Buzz", @this.ReadToEnd());
        }
    }
}