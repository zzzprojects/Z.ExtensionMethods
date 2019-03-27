// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_NullIfEmpty
    {
        [TestMethod]
        public void NullIfEmpty()
        {
            // Type
            string @this = "";

            // Examples
            string value = @this.NullIfEmpty(); // return null;

            // Unit Test
            Assert.IsNull(value);
        }
    }
}