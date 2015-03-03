using System.Collections.Generic;
using System.Collections.Specialized;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Specialized_NameValueCollection_ToDictionary
    {
        [TestMethod]
        public void ToDictionary()
        {
            // Type
            var @this = new NameValueCollection {{"Fizz", "Buzz"}};

            // Exemples
            IDictionary<string, object> result = @this.ToDictionary(); // return a Dictionary;

            // Unit Test
            Assert.AreEqual("Buzz", result["Fizz"]);
        }
    }
}