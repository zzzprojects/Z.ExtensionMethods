using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_FileInfo_WriteAllLines
    {
        [TestMethod]
        public void WriteAllLines()
        {
            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_WriteAllLines.txt"));

            // Intialization
            using (FileStream stream = @this.Create())
            {
            }

            // Examples
            @this.WriteAllLines(new[] {"Fizz", "Buzz"});

            // Unit Test
            Assert.AreEqual("Fizz" + Environment.NewLine + "Buzz" + Environment.NewLine, @this.ReadToEnd());
        }
    }
}