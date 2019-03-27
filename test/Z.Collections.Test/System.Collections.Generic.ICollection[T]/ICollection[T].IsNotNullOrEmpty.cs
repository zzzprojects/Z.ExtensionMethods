// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_IsNotNullOrEmpty
    {
        [TestMethod]
        public void IsNotNullOrEmpty()
        {
            // Type
            var @this = new List<string>();

            // Examples
            bool value1 = @this.IsNotNullOrEmpty(); // return false;

            @this.Add("Fizz");
            bool value2 = @this.IsNotNullOrEmpty(); // return true;

            @this = null;
            bool value3 = @this.IsNotNullOrEmpty(); // return false;

            // Unit Test
            Assert.IsFalse(value1);
            Assert.IsTrue(value2);
            Assert.IsFalse(value3);
        }
    }
}