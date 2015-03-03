using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ToXmlDocument
    {
        [TestMethod]
        public void ToXmlDocument()
        {
            // Type
            string @this = "<Fizz>Buzz</Fizz>";

            // Examples
            XmlDocument value = @this.ToXmlDocument(); // return a XmlDocument from the specified string.

            // Unit Test
            Assert.AreEqual("<Fizz>Buzz</Fizz>", value.OuterXml);
        }
    }
}