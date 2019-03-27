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
    public class System_Object_IsAssignableFrom
    {
        [TestMethod]
        public void IsAssignableFrom()
        {
            // Type
            var stringObject = (object) "FizzBuzz";

            // Exemples
            bool result1 = stringObject.IsAssignableFrom(typeof (string)); // return true;
            bool result2 = stringObject.IsAssignableFrom<string>(); // return true;
            bool result3 = stringObject.IsAssignableFrom<object>(); // return false;
            bool result4 = stringObject.IsAssignableFrom<int>(); // return false;

            // Unit Test
            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
            Assert.IsFalse(result4);
        }
    }
}