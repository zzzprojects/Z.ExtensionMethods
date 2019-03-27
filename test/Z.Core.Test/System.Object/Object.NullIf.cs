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
    public class System_Object_NullIf
    {
        [TestMethod]
        public void NullIf()
        {
            // Type
            string @this = "1";

            // Exemples
            string result1 = @this.NullIf(x => x == "1"); // return null;
            string result2 = @this.NullIf(x => x == "2"); // return "1";

            // Unit Test
            Assert.AreEqual(null, result1);
            Assert.AreEqual("1", result2);
        }
    }
}