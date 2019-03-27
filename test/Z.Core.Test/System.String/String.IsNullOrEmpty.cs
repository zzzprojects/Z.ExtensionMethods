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
    public class System_String_IsNullOrEmpty
    {
        [TestMethod]
        public void IsNullOrEmpty()
        {
            // Type
            string @thisValue = "Fizz";
            string @thisNull = null;

            // Examples
            bool value1 = @thisValue.IsNullOrEmpty(); // return false;
            bool value2 = @thisNull.IsNullOrEmpty(); // return true;

            // Unit Test
            Assert.IsFalse(value1);
            Assert.IsTrue(value2);
        }
    }
}