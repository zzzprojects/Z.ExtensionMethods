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
    public class System_DateTime_EndOfWeek
    {
        [TestMethod]
        public void EndOfWeek()
        {
            // Type
            var @this = new DateTime(2014, 04, 16);

            // Examples
            DateTime value = @this.EndOfWeek(); // value = "2013/04/13 23:59:59:999";

            // Unit Test
            Assert.AreEqual(new DateTime(2014, 04, 19, 23, 59, 59, 999), value);
        }
    }
}