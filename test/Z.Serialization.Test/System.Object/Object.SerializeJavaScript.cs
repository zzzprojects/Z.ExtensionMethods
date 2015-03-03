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