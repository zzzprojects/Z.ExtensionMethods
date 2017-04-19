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