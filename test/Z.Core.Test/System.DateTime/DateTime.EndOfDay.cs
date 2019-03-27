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
    public class System_DateTime_EndOfDay
    {
        [TestMethod]
        public void EndOfDay()
        {
            // Type
            DateTime @this = DateTime.Now;

            // Examples
            DateTime value = @this.EndOfDay(); // value = "yyyy/MM/dd 23:59:59:999";

            // Unit Test
            Assert.AreEqual(new DateTime(value.Year, value.Month, value.Day, 23, 59, 59, 999), value);
        }
    }
}