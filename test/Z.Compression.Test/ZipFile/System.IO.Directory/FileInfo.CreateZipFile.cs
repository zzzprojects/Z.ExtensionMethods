// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
#if NET45_OR_GREATER
using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Compression.Test
{
    [TestClass]
    public class System_IO_FileInfo_CreateZipFile
    {
        [TestMethod]
        public void CreateZipFile()
        {
            var dir = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CreateZipFile"));
            var dir2 = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CreateZipFile_Zip"));

            if (dir.Exists)
            {
                dir.Clear();
            }
            if (dir2.Exists)
            {
                dir2.Clear();
            }

            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CreateZipFile", "Examples_System_IO_FileInfo_CreateZipFile.txt"));
            var zip = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CreateZipFile_Zip", "Examples_System_IO_FileInfo_CreateZipFile.zip"));

            Directory.CreateDirectory(@this.Directory.FullName);
            Directory.CreateDirectory(zip.Directory.FullName);

            // Intialization
            using (FileStream stream = @this.Create())
            {
            }

            // Examples
            @this.Directory.CreateZipFile(zip);

            // Unit Test
            Assert.IsTrue(zip.Exists);
        }
    }
}
#endif