// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Serialization.Test
{
    [TestClass]
    public class System_Object_SerializeJavaScript
    {
        [TestMethod]
        public void SerializeJavaScript()
        {
            // Type
            var @this = new List<string> {"Fizz", "Buzz"};

            // Examples
            string result = @this.SerializeJavaScript(); // Serialize the object into a string.

            // Unit Test
            var result2 = result.DeserializeJavaScript<List<string>>();
            Assert.AreEqual(2, result2.Count);
            Assert.AreEqual("Fizz", result2[0]);
            Assert.AreEqual("Buzz", result2[1]);
        }
    }
}