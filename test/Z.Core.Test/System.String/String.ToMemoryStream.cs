// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ToMemoryStream
    {
        [TestMethod]
        public void ToMemoryStream()
        {
            // Type
            string @this = "FizzBuzz";

            // Examples
            using (Stream value = @this.ToMemoryStream()) // return a MemoryStream from the text
            {
                // Unit Test
                Assert.IsNotNull(value);
            }
        }
    }
}