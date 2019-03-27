// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Compression.Test
{
    [TestClass]
    public class System_String_CompressGZip
    {
        [TestMethod]
        public void CompressGZip()
        {
            // Type
            string @this = "FizzBuzz";

            // Exemples
            byte[] result = @this.CompressGZip();

            // Unit Test
            Assert.AreEqual("FizzBuzz", result.DecompressGZip());
        }
    }
}