// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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