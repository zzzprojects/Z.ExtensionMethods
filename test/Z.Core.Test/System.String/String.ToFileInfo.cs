// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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