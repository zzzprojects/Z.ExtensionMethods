// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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