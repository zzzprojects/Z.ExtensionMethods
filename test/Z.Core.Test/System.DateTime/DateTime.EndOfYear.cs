// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_EndOfYear
    {
        [TestMethod]
        public void EndOfYear()
        {
            // Type
            var @this = new DateTime(2013, 04, 13);

            // Examples
            DateTime value = @this.EndOfYear(); // value = "2013/12/31 23:59:59:999";

            // Unit Test
            Assert.AreEqual(new DateTime(2013, 12, 31, 23, 59, 59, 999), value);
        }
    }
}