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
    public class System_ByteArray_ToMemoryStream
    {
        [TestMethod]
        public void ToMemoryStream()
        {
            // Type
            var @this = new Byte[1] {1};

            // Exemples
            MemoryStream result = @this.ToMemoryStream(); // return an iMemoryStream

            // Unit Test
            Assert.AreEqual(1, result.ToArray()[0]);
        }
    }
}