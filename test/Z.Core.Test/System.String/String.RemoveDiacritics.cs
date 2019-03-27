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
    public class System_String_RemoveDiacritics
    {
        [TestMethod]
        public void RemoveDiacritics()
        {
            // Type
            string @this = "éèêôîâ";

            // Examples
            string value = @this.RemoveDiacritics(); // return "eeeoia";

            // Unit Test
            Assert.AreEqual("eeeoia", value);
        }
    }
}