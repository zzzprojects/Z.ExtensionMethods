// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Compression.Test
{
    [TestClass]
    public class System_IO_FileInfo_CreateGZip
    {
        [TestMethod]
        public void CreateGZip()
        {
            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_CreateGZip.txt"));
            var output = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_CreateGZip.gz"));

            // Intialization
            using (FileStream stream = @this.Create())
            {
            }

            // Examples
            @this.CreateGZip(output);

            // Unit Test
            Assert.IsTrue(output.Exists);
        }
    }
}