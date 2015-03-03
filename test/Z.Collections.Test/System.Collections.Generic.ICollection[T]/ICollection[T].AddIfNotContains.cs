using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_AddIfNotContains
    {
        [TestMethod]
        public void AddIfNotContains()
        {
            // Type
            var @this = new List<string> {"FizzExisting"};

            // Examples
            @this.AddIfNotContains("Fizz"); // Add "Fizz" value
            @this.AddIfNotContains("FizzExisting"); // Doesn't add "FizzExisting" value, the Collection already contains it.

            // Unit Test
            Assert.AreEqual(2, @this.Count);
        }
    }
}