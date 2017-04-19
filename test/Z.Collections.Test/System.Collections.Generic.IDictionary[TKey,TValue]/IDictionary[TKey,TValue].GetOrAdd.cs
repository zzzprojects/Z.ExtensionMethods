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
    public class System_Collections_Generic_IDictionary_TKey_TValue_GetOrAdd
    {
        [TestMethod]
        public void GetOrAdd()
        {
            // Type
            var @this = new Dictionary<string, string>();

            // Examples
            string value1 = @this.GetOrAdd("Fizz", "Buzz"); // return "Buzz";
            string value2 = @this.GetOrAdd("Fizz", "Buzz2"); // return "Buzz"; // The Dictionary already contains the key
            string value3 = @this.GetOrAdd("Fizz2", s => "Buzz"); // return "Buzz";

            // Unit Test
            Assert.AreEqual("Buzz", value1);
            Assert.AreEqual("Buzz", value2);
            Assert.AreEqual("Buzz", value3);
        }
    }
}