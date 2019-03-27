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
    public class System_IO_FileInfo_ExtractZipFileToDirectory
    {
        [TestMethod]
        public void CreateZipFile()
        {
            var dir = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExtractZipFileToDirectory"));
            var dir2 = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExtractZipFileToDirectory_Zip"));
            var dir3 = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExtractZipFileToDirectory_Output"));

            if (dir.Exists)
            {
                dir.Clear();
            }
            if (dir2.Exists)
            {
                dir2.Clear();
            }
            if (dir3.Exists)
            {
                dir3.Clear();
            }

            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExtractZipFileToDirectory", "Examples_System_IO_FileInfo_ExtractZipFileToDirectory.txt"));
            var zip = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExtractZipFileToDirectory_Zip", "Examples_System_IO_FileInfo_ExtractZipFileToDirectory.zip"));
            var output = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExtractZipFileToDirectory_Output"));

            Directory.CreateDirectory(@this.Directory.FullName);
            Directory.CreateDirectory(zip.Directory.FullName);
            Directory.CreateDirectory(output.FullName);

            // Intialization
            using (FileStream stream = @this.Create())
            {
            }
            @this.Directory.CreateZipFile(zip);

            var file = output.GetFiles();
            // Examples
            Assert.AreEqual(0, output.GetFiles().Length);
            zip.ExtractZipFileToDirectory(output);

            // Unit Test
            Assert.AreEqual(1, output.GetFiles().Length);
        }
    }
}
#endif