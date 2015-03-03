using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_FileInfo_ReadAllText
    {
        [TestMethod]
        public void ReadAllText()
        {
            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_ReadAllText.txt"));

            // Intialization
            using (FileStream stream = @this.Create())
            {
                byte[] byteToWrites = Encoding.Default.GetBytes("Fizz" + Environment.NewLine + "Buzz");
                stream.Write(byteToWrites, 0, byteToWrites.Length);
            }

            // Examples
            string result = @this.ReadAllText(); // return "Fizz" + Environment.NewLine + "Buzz";

            // Unit Test
            Assert.AreEqual("Fizz" + Environment.NewLine + "Buzz", result);
        }
    }
}