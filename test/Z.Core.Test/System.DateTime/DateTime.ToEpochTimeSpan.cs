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
    public class System_DateTime_ToEpochTimeSpan
    {
        [TestMethod]
        public void ToEpochTimeSpan()
        {
            // Type
            DateTime @this = DateTime.Now;

            // Exemples
            TimeSpan result = @this.ToEpochTimeSpan(); // return TimeSpan

            // Unit Test
            Assert.AreEqual(@this.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds, result.TotalMilliseconds);
        }
    }
}