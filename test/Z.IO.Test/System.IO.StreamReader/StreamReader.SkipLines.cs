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