using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_IDictionary_TKey_TValue_ToSortedDictionary
    {
        [TestMethod]
        public void ToSortedDictionary()
        {
            // Type
            var @this = new Dictionary<string, string> {{"Fizz", "Buzz"}};

            // Exemples
            SortedDictionary<string, string> result = @this.ToSortedDictionary(); // return new SortedDictionary

            // Unit Test
            Assert.AreEqual("Buzz", result["Fizz"]);
        }
    }
}