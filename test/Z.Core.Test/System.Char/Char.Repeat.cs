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
    public class System_Char_Repeat
    {
        [TestMethod]
        public void Repeat()
        {
            // Type
            char @this = 'F';

            // Examples
            string result = @this.Repeat(3); // return "FFF";

            // Unit Test
            Assert.AreEqual("FFF", result);
        }
    }
}