using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_SaveAs
    {
        [TestMethod]
        public void SaveAs()
        {
            var fileInfo = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_String_SaveAs.txt"));
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_String_SaveAs2.txt");

            // Type
            string @this = "Fizz";

            // Examples
            @this.SaveAs(filePath); // Save string in a file.
            @this.SaveAs(fileInfo); // Save string in a file.
            @this.SaveAs(fileInfo, true); // Append string to existing file.

            // Unit Test
            Assert.IsTrue(fileInfo.Exists);
            Assert.IsTrue(new FileInfo(filePath).Exists);
        }
    }
}