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
    public class System_DateTime_IsMorning
    {
        [TestMethod]
        public void IsMorning()
        {
            // Type
            var @thisMorning = new DateTime(2014, 04, 12, 8, 0, 0);
            var @thisAfternoon = new DateTime(2014, 04, 12, 17, 0, 0);


            // Exemples
            bool result1 = @thisMorning.IsMorning(); // return true;
            bool result2 = @thisAfternoon.IsMorning(); // return false;

            // Unit Test
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}