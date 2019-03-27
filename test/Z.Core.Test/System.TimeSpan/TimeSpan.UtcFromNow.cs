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
    public class System_TimeSpan_UtcFromNow
    {
        [TestMethod]
        public void UtcFromNow()
        {
            // Type
            var @this = new TimeSpan(1, 0, 0, 0);

            // Examples
            DateTime value = @this.UtcFromNow(); // return yesterday.

            // Unit Test
            Assert.IsTrue(DateTime.UtcNow.Subtract(value).Days <= -1);
        }
    }
}