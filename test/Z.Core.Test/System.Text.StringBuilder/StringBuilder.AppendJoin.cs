// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_AppendJoin
    {
        [TestMethod]
        public void AppendJoin()
        {
            var list = new List<string> {"Fizz", "Buzz"};

            // Type
            var @this = new StringBuilder();


            // Exemples
            @this.AppendJoin(",", list.ToArray()); // return "Fizz,Buzz";

            // Unit Test
            Assert.AreEqual("Fizz,Buzz", @this.ToString());
        }
    }
}