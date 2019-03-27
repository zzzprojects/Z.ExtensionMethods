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
    public class System_Object_ToNullableInt32
    {
        [TestMethod]
        public void ToNullableInt32()
        {
            // Type
            object @this = null;
            object @thisValue = "32";

            // Exemples
            int? result1 = @this.ToNullableInt32(); // return null;
            int? result2 = @thisValue.ToNullableInt32(); // return 32;

            // Unit Test
            Assert.IsFalse(result1.HasValue);
            Assert.AreEqual(32, result2.Value);
        }
    }
}