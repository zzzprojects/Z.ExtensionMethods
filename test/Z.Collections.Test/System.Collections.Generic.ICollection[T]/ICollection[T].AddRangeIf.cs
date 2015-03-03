using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_AddRangeIf
    {
        [TestMethod]
        public void AddRangeIf()
        {
            // Type
            var @this = new List<string> {"FizzExisting"};

            // Examples
            @this.AddRangeIf(x => !@this.Contains(x), "Fizz"); // Add "Fizz" value
            @this.AddRangeIf(x => !@this.Contains(x), "FizzExisting", "Buzz"); // Add "Buzz" value but doesn't add "FizzExisting"

            // Unit Test
            Assert.AreEqual(3, @this.Count);
        }
    }
}