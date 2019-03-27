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
    public class System_DateTime_StartOfYear
    {
        [TestMethod]
        public void StartOfYear()
        {
            // Type
            DateTime @this = DateTime.Now;

            // Examples
            DateTime value = @this.StartOfYear(); // value = "yyyy/01/01 00:00:00:000";

            // Unit Test
            Assert.AreEqual(new DateTime(value.Year, 1, 1), value);
        }
    }
}