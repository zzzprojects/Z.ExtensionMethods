// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_IDictionary_String_Object_ToExpando
    {
        [TestMethod]
        public void ToExpando()
        {
            // Type
            var @this = new Dictionary<string, object> {{"Fizz", "Buzz"}};

            // Exemples
            dynamic result = @this.ToExpando(); // return an expando object;

            // Unit Test
            Assert.AreEqual("Buzz", result.Fizz);
        }
    }
}