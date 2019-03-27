// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_Concatenate
    {
        [TestMethod]
        public void Concatenate()
        {
            var list = new List<string> {"Fizz", "Buzz"};

            // Exemples
            var result1 = list.Concatenate();
            var result2 = list.Concatenate(x => x + x);

            // Unit Test
            Assert.AreEqual("FizzBuzz", result1);
            Assert.AreEqual("FizzFizzBuzzBuzz", result2);
        }
    }
}