// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_IsPast
    {
        [TestMethod]
        public void IsPast()
        {
            // Type
            DateTime @this = DateTime.Now.AddDays(1);

            // Examples
            bool value1 = @this.IsPast(); // return false;
            bool value2 = @this.AddYears(-1).IsPast(); // return true;

            // Unit Test
            Assert.IsFalse(value1);
            Assert.IsTrue(value2);
        }
    }
}