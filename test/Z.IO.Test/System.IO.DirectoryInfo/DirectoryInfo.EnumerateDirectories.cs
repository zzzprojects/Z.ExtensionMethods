// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_DirectoryInfo_EnumerateDirectories
    {
        [TestMethod]
        public void EnumerateDirectories()
        {
            // Type
            var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "System_IO_DirectoryInfo_EnumerateDirectories"));
            Directory.CreateDirectory(root.FullName);
            root.CreateSubdirectory("Directory1");
            root.CreateSubdirectory("Directory2");

            // Exemples
            List<DirectoryInfo> result = root.EnumerateDirectories().ToList();

            // Unit Test
            Assert.AreEqual(2, result.Count);
        }
    }
}