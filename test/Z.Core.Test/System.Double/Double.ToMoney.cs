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
    public class System_Double_ToMoney
    {
        [TestMethod]
        public void ToMoney()
        {
            // Type
            double @this1 = 2.311;
            double @this2 = 2.3191;

            // Exemples
            double result1 = @this1.ToMoney(); // return 2.31;
            double result2 = @this2.ToMoney(); // return 2.32;

            // Unit Test
            Assert.AreEqual(2.31, result1);
            Assert.AreEqual(2.32, result2);
        }
    }
}