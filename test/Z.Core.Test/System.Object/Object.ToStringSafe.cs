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
    public class System_Object_ToStringSafe
    {
        [TestMethod]
        public void ToStringSafe()
        {
            // Type
            int @thisValue = 1;
            string @thisNull = null;

            // Exemples
            string result1 = @thisValue.ToStringSafe(); // return "1";
            string result2 = @thisNull.ToStringSafe(); // return "";

            // Unit Test
            Assert.AreEqual(result1, "1");
            Assert.AreEqual(result2, "");
        }
    }
}