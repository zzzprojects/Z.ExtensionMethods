// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_FileInfo_ReadToEnd
    {
        [TestMethod]
        public void ReadToEnd()
        {
            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_ReadToEnd.txt"));

            // Intialization
            using (FileStream stream = @this.Create())
            {
                byte[] byteToWrites = Encoding.Default.GetBytes("Fizz" + Environment.NewLine + "Buzz");
                stream.Write(byteToWrites, 0, byteToWrites.Length);
            }

            // Examples
            string result = @this.ReadToEnd(); // return "Fizz" + Environment.NewLine + "Buzz";

            // Unit Test
            Assert.AreEqual("Fizz" + Environment.NewLine + "Buzz", result);
        }
    }
}