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
    public class System_String_IsNotNullOrWhitespace
    {
        [TestMethod]
        public void IsNotNullOrEmpty()
        {
            // Type
            string @thisNull = null;

            // Examples
            bool value1 = "  Z".IsNotNullOrWhiteSpace(); // return true;
            bool value2 = @thisNull.IsNotNullOrWhiteSpace(); // return false;
            bool value3 = "".IsNotNullOrWhiteSpace(); // return false;
            bool value4 = "   ".IsNotNullOrWhiteSpace(); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
            Assert.IsFalse(value3);
            Assert.IsFalse(value4);
        }
    }
}