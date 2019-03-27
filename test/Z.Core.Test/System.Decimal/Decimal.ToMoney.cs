// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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