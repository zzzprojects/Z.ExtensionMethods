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
    public class System_IO_Stream_ToByteArray
    {
        [TestMethod]
        public void ToByteArray()
        {
            var fileInfo = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_ReadToEnd.txt"));

            // Examples
            byte[] value;
            using (FileStream @this = fileInfo.Create())
            {
                @this.WriteByte(0);
                @this.Position = 0;
                value = @this.ToByteArray(); // return "0";
            }

            // Unit Test
            Assert.AreEqual(0, value[0]);
        }
    }
}