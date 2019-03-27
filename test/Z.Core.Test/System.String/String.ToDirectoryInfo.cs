// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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