// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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