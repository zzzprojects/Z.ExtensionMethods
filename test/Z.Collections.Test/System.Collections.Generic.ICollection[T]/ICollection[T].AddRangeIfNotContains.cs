using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_AddRangeIfNotContains
    {
        [TestMethod]
        public void AddRangeIfNotContains()
        {
            // Type
            var @this = new List<string> {"FizzExisting"};

            // Examples
            @this.AddRangeIfNotContains("Fizz"); // Add "Fizz" value
            @this.AddRangeIfNotContains("FizzExisting", "Buzz"); // Add "Buzz" value but doesn't add "Fizz"

            // Unit Test
            Assert.AreEqual(3, @this.Count);
        }
    }
}