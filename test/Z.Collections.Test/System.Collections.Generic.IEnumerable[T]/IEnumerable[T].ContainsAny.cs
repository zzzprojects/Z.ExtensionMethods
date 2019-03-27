// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_IEnumerable_T_ContainsAny
    {
        [TestMethod]
        public void ContainsAny()
        {
            // Type
            IEnumerable<string> @this = new List<string> {"zA", "zB", "C"}.AsEnumerable();

            // Exemples
            bool value1 = @this.ContainsAny("1", "zA", "3"); // return true;
            bool value2 = @this.ContainsAny("1", "2", "3"); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}