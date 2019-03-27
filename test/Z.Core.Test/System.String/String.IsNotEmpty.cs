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
    public class System_String_IsNotEmpty
    {
        [TestMethod]
        public void IsNotEmpty()
        {
            // Type
            string @thisEmpty = "";
            string @thisNotEmpty = "FizzBuzz";

            // Exemples
            bool result1 = @thisEmpty.IsNotEmpty(); // return false;
            bool result2 = @thisNotEmpty.IsNotEmpty(); // return true;

            // Unit Test
            Assert.IsFalse(result1);
            Assert.IsTrue(result2);
        }
    }
}