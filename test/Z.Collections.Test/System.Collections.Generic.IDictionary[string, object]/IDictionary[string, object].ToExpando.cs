using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_IDictionary_String_Object_ToExpando
    {
        [TestMethod]
        public void ToExpando()
        {
            // Type
            var @this = new Dictionary<string, object> {{"Fizz", "Buzz"}};

            // Exemples
            dynamic result = @this.ToExpando(); // return an expando object;

            // Unit Test
            Assert.AreEqual("Buzz", result.Fizz);
        }
    }
}