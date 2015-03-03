using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_IDictionary_TKey_TValue_RemoveIfContainsKey
    {
        [TestMethod]
        public void RemoveIfContainsKey()
        {
            // Type
            var @this = new Dictionary<string, string> {{"Fizz", "Buzz"}};

            // Examples
            @this.RemoveIfContainsKey("Fizz"); // Remove "Fizz"
            @this.RemoveIfContainsKey("Fizz2"); // Remove Nothing

            // Unit Test
            Assert.AreEqual(0, @this.Count);
        }
    }
}