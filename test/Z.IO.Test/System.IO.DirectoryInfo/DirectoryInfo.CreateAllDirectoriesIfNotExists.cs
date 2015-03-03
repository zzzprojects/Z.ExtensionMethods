using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_DirectoryInfo_EnsureDirectoryExists
    {
        [TestMethod]
        public void EnsureDirectoryExists()
        {
            // Type
            var @this = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EnsureDirectoryExists", "SubDirectory"));

            // Examples
            @this.EnsureDirectoryExists(); // Create the directory the first time.
            @this.EnsureDirectoryExists(); // C// Doesn't create the directory and does't throw an error.

            // Unit Test
            Assert.IsTrue(@this.Exists);
        }
    }
}