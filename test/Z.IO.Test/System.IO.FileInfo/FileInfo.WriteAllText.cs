using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_FileInfo_WriteAllText
    {
        [TestMethod]
        public void WriteAllText()
        {
            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_WriteAllText.txt"));

            // Intialization
            using (FileStream stream = @this.Create())
            {
            }

            // Examples
            @this.WriteAllText("Fizz" + Environment.NewLine + "Buzz");

            // Unit Test
            Assert.AreEqual("Fizz" + Environment.NewLine + "Buzz", @this.ReadToEnd());
        }
    }
}