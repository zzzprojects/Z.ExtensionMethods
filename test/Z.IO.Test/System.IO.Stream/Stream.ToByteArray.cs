// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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