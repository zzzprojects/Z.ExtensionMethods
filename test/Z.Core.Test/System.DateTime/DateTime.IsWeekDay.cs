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
    public class System_DateTime_IsWeekDay
    {
        [TestMethod]
        public void IsWeekDay()
        {
            // Type
            var @thisFriday = new DateTime(2013, 11, 22); // Friday
            var @thisSaturday = new DateTime(2013, 11, 23); // Saturday

            // Examples
            bool value1 = @thisFriday.IsWeekDay(); // return true;
            bool value2 = @thisSaturday.IsWeekDay(); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}