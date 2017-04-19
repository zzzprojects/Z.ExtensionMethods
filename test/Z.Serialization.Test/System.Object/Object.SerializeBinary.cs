// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Serialization.Test
{
    [TestClass]
    public class System_Object_SerializeBinary
    {
        [TestMethod]
        public void SerializeBinary()
        {
            // Type
            var @this = new Dictionary<string, string> {{"Fizz", "Buzz"}};

            // Examples
            string result = @this.SerializeBinary(); // Serialize the object into a string.

            // Unit Test
            using (var stream = new MemoryStream(Encoding.Default.GetBytes(result)))
            {
                var binaryRead = new BinaryFormatter();
                var dict = (Dictionary<string, string>) binaryRead.Deserialize(stream);
                Assert.IsTrue(dict.ContainsKey("Fizz"));
            }
        }
    }
}