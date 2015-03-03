using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_DirectoryInfo_PathCombineFile
    {
        [TestMethod]
        public void PathCombine()
        {
            // Type
            var @this = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            string path1 = "Fizz";
            string path2 = "Buzz";

            // Exemples
            FileInfo result = @this.PathCombineFile(path1, path2); // Combine path1 and path2 with the DirectoryInfo

            // Unit Test
            var expected = new FileInfo(Path.Combine(@this.FullName, path1, path2));
            Assert.AreEqual(expected.FullName, result.FullName);
        }
    }
}