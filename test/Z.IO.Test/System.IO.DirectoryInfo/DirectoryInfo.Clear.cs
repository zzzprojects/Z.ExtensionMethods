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