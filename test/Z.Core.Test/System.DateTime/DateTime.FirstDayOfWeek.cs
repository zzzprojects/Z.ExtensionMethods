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
    public class System_DateTime_FirstDayOfWeek
    {
        [TestMethod]
        public void FirstDayOfWeek()
        {
            // Type
            var @this = new DateTime(2014, 04, 16);

            // Exemples
            DateTime result = @this.FirstDayOfWeek(); // result = "2013/04/13";

            // Unit Test
            Assert.AreEqual(new DateTime(2014, 04, 13), result);
        }
    }
}