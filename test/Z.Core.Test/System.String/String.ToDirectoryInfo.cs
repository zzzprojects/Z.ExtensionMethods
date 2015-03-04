// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ToDirectoryInfo
    {
        [TestMethod]
        public void ToDirectoryInfo()
        {
            // Type
            string @this = AppDomain.CurrentDomain.BaseDirectory;

            // Examples
            DirectoryInfo value = @this.ToDirectoryInfo(); // return a DirectoryInfo from the specified path.

            // Unit Test
            Assert.AreEqual(@this, value.FullName);
        }
    }
}