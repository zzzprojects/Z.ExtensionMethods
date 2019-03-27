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
    public class System_Guid_IsNotEmpty
    {
        [TestMethod]
        public void IsNotEmpty()
        {
            // Type
            Guid guidEmpty = Guid.Empty;
            Guid guidValue = Guid.NewGuid();

            // Unit Test
            Assert.IsFalse(guidEmpty.IsNotEmpty());
            Assert.IsTrue(guidValue.IsNotEmpty());
        }
    }
}