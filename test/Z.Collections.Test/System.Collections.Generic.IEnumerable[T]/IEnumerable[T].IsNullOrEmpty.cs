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
    public class System_Collections_Generic_IEnumerable_T_IsNullOrEmpty
    {
        [TestMethod]
        public void IsNullOrEmpty()
        {
            // Type
            List<string> @thisNull = null;
            IEnumerable<string> @thisEmpty = new List<string>().AsEnumerable();
            IEnumerable<string> @thisNotEmpty = new List<string> {"Fizz"}.AsEnumerable();

            // Exemples
            bool result1 = @thisNull.IsNullOrEmpty(); // return true;
            bool result2 = @thisEmpty.IsNullOrEmpty(); // return true;
            bool result3 = @thisNotEmpty.IsNullOrEmpty(); // return false;

            // Unit Test
            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
        }
    }
}