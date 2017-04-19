// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Decimal_ToMoney
    {
        [TestMethod]
        public void ToMoney()
        {
            // Type
            decimal @this1 = 2.311M;
            decimal @this2 = 2.3191M;

            // Exemples
            decimal result1 = @this1.ToMoney(); // return 2.31;
            decimal result2 = @this2.ToMoney(); // return 2.32;

            // Unit Test
            Assert.AreEqual(2.31M, result1);
            Assert.AreEqual(2.32M, result2);
        }
    }
}