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
    public class System_DateTime_Age
    {
        [TestMethod]
        public void Age()
        {
            // Type
            var @this = new DateTime(1981, 01, 01);

            // Exemples
            int result = @this.Age(); // result CurrentYear - 1981

            // Unit Test
            Assert.AreEqual(DateTime.Now.Year - 1981, result);
        }
    }
}