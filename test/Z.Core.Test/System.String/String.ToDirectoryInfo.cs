using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ToDirectoryInfo
    {
        [TestMethod]
        public void ToDirectoryInfo()
        {
            // Type
            string @this = AppDomain.CurrentDomain.BaseDirectory;

            // Examples
            DirectoryInfo value = @this.ToDirectoryInfo(); // return a DirectoryInfo from the specified path.

            // Unit Test
            Assert.AreEqual(@this, value.FullName);
        }
    }
}