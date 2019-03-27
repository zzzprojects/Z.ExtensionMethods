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
    public class System_Boolean_ToBinary
    {
        [TestMethod]
        public void ToBinary()
        {
            // Type
            bool @thisTrue = true;
            bool @thisFalse = false;

            // Exemples
            byte result1 = @thisTrue.ToBinary(); // return 1;
            byte result2 = @thisFalse.ToBinary(); // return 0;

            // Unit Test
            Assert.AreEqual(1, result1);
            Assert.AreEqual(0, result2);
        }
    }
}