using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_IDictionary_TKey_TValue_AddIfNotContainsKey
    {
        [TestMethod]
        public void AddIfNotContainsKey()
        {
            // Type
            var @this = new Dictionary<string, string>();

            // Examples
            @this.AddIfNotContainsKey("Fizz", "FizzBuzz"); // Add "FizzBuzz";
            @this.AddIfNotContainsKey("Fizz", () => "Buzz"); // Add Nothing;

            // Unit Test
            Assert.AreEqual("FizzBuzz", @this["Fizz"]);
        }
    }
}