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
    public class System_Enum_In
    {
        [TestMethod]
        public void In()
        {
            // Type
            var @this = Environment.SpecialFolder.Desktop;

            // Exemples
            bool result1 = @this.In(Environment.SpecialFolder.Desktop, Environment.SpecialFolder.DesktopDirectory); // return true;
            bool result2 = @this.In(Environment.SpecialFolder.DesktopDirectory); // return false;

            // Unit Test
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}