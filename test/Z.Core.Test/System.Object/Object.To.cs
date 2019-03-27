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
    public class System_Object_To
    {
        [TestMethod]
        public void To()
        {
            string nullValue = null;
            string value = "1";
            object dbNullValue = DBNull.Value;

            // Exemples
            var result1 = value.To<int>(); // return 1;
            var result2 = value.To<int?>(); // return 1;
            var result3 = nullValue.To<int?>(); // return null;
            var result4 = dbNullValue.To<int?>(); // return null;

            // Unit Test
            Assert.AreEqual(1, result1);
            Assert.AreEqual(1, result2.Value);
            Assert.IsFalse(result3.HasValue);
            Assert.IsFalse(result4.HasValue);
        }
    }
}