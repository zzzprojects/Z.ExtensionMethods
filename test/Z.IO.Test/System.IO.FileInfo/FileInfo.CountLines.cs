// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_FileInfo_CountLines
    {
        [TestMethod]
        public void CountLines()
        {
            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_ReadAllLines.txt"));

            // Intialization
            using (FileStream stream = @this.Create())
            {
                byte[] byteToWrites = Encoding.Default.GetBytes("Fizz" + Environment.NewLine + "Buzz" + Environment.NewLine + "Fizz2");
                stream.Write(byteToWrites, 0, byteToWrites.Length);
            }

            // Examples
            var result1 = @this.CountLines(); // return 3;
            var result2 = @this.CountLines(x => !x.Contains("Buzz")); // return 2;

            // Unit Test
            Assert.AreEqual(3, result1);
            Assert.AreEqual(2, result2);
        }
    }
}