// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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