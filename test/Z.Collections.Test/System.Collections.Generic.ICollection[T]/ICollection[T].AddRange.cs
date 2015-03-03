using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_AddRange
    {
        [TestMethod]
        public void AddRange()
        {
            // Type
            var @this = new List<string>();

            // Examples
            @this.AddRange("Fizz", "Buzz"); // Add "Fizz" and "Buzz" value

            // Unit Test
            Assert.IsTrue(@this.Contains("Fizz"));
            Assert.IsTrue(@this.Contains("Buzz"));
        }
    }
}