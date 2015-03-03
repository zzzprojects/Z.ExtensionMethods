using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_DirectoryInfo_Clear
    {
        [TestMethod]
        public void Clear()
        {
            // Type
            var @this = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DirectoryInfo_Clear"));
            Directory.CreateDirectory(@this.FullName);
            @this.CreateSubdirectory("FizzBuzz");
            int result1 = @this.GetDirectories().Length;

            // Exemples
            @this.Clear(); // Remove all file and directory in this directory

            // Unit Test
            int result2 = @this.GetDirectories().Length;
            Assert.AreEqual(1, result1);
            Assert.AreEqual(0, result2);
        }
    }
}