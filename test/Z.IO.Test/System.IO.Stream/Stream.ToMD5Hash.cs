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
    public class System_IO_Stream_ToMD5Hash
    {
        [TestMethod]
        public void ToMD5Hash()
        {
            var fileInfo = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_ToMD5Hash.txt"));

            // Examples
            string result;

            using (FileStream @this = fileInfo.Create())
            {
                @this.WriteByte(0);
                result = @this.ToMD5Hash(); // return "D41D8CD98F00B204E9800998ECF8427E";
            }

            // Unit Test
            Assert.AreEqual("D41D8CD98F00B204E9800998ECF8427E", result);
        }
    }
}