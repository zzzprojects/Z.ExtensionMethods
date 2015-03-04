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
    public class System_String_ToFileInfo
    {
        [TestMethod]
        public void ToFileInfo()
        {
            // Type
            string @this = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_String_ToFileInfo.txt");

            // Examples
            FileInfo value = @this.ToFileInfo(); // return a FileInfo for the specified path.

            // Unit Test
            Assert.AreEqual(@this, value.FullName);
        }
    }
}