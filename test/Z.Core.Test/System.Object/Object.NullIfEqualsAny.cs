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
    public class System_Object_NullIfEqualsAny
    {
        [TestMethod]
        public void NullIfEqualsAny()
        {
            // Type
            object @this = "1";

            // Exemples
            object result1 = @this.NullIfEqualsAny("0", "1", "2"); // return null;
            object result2 = @this.NullIfEqualsAny("2"); // return "1";

            // Unit Test
            Assert.AreEqual(null, result1);
            Assert.AreEqual("1", result2);
        }
    }
}