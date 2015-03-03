using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Serialization.Test
{
    [TestClass]
    public class System_Object_SerializeXml
    {
        [TestMethod]
        public void SerializeXml()
        {
            // Type
            var @this = new List<string> {"Fizz", "Buzz"};

            // Examples
            string value = @this.SerializeXml(); // Serialize the object into a string.

            // Unit Test
            Assert.AreEqual("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>Fizz</string>\r\n  <string>Buzz</string>\r\n</ArrayOfString>", value);
        }
    }
}