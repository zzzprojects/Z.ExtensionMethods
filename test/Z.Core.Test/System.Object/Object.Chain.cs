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
    public class System_Object_Chain
    {
        [TestMethod]
        public void Chain()
        {
            // Type
            var @this = new List<string>();

            // Exemples
            @this.Chain(x => x.Add("Fizz"))
                .Chain(x => x.Add("Buzz"))
                .Chain(x => x.Add("FizzBuzz")); // Chain multiple action

            // Unit Test
            Assert.AreEqual(3, @this.Count);
        }
    }
}