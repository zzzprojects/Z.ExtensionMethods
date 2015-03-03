using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_GetValueOrDefault
    {
        [TestMethod]
        public void GetValueOrDefault()
        {
            // Type
            var @this = new XmlDocument();

            // Exemples
            string result1 = @this.GetValueOrDefault(x => x.FirstChild.InnerXml, "FizzBuzz"); // return "FizzBuzz";
            string result2 = @this.GetValueOrDefault(x => x.FirstChild.InnerXml, () => "FizzBuzz"); // return "FizzBuzz"

            // Unit Test
            Assert.AreEqual("FizzBuzz", result1);
            Assert.AreEqual("FizzBuzz", result2);
        }
    }
}