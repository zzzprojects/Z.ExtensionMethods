using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_IDictionary_ToHashtable
    {
        [TestMethod]
        public void ToHashtable()
        {
            // Type
            var @this = new Dictionary<string, string> {{"Fizz", "Buzz"}};

            // Exemples
            Hashtable result = @this.ToHashtable(); // return Hashtable;

            // Unit Test
            Assert.AreEqual("Buzz", result["Fizz"]);
        }
    }
}