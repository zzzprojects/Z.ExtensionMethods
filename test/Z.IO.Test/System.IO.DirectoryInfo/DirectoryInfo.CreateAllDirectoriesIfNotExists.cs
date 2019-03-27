// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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