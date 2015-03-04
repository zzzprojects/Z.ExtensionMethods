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
    public class System_IO_FileInfo_CreateDirectory
    {
        [TestMethod]
        public void CreateDirectory()
        {
            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DirectoryInfo_CreateDirectory", "SubDirectory1", "SubDirectory2", "CreateDirectory.txt"));

            // Examples
            @this.CreateDirectory(); // Create all subdirectories

            // Unit Test
            Assert.IsTrue(@this.Directory.Exists);
        }
    }
}