// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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