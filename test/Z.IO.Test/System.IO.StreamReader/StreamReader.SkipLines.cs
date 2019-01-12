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
    public class System_IO_StreamReader_SkipLines
    {
        [TestMethod]
        public void SkipLines()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_SkipLines.txt");

            File.WriteAllLines(filePath, new[]
            {
                "Line1",
                "Line2",
                "Line3",
                "Line4"
            });

            using (var file = File.OpenText(filePath))
            {
                file.SkipLines(2);
                var nextLine = file.ReadLine();

                // Unit Test
                Assert.AreEqual("Line3", nextLine);
            }
        }
    }
}