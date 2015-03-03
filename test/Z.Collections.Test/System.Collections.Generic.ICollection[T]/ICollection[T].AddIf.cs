using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_AddIf
    {
        [TestMethod]
        public void AddIf()
        {
            // Type
            var @this = new List<string>();

            // Examples
            @this.AddIf(s => true, "Fizz"); // Add "Fizz" value
            @this.AddIf(s => false, "Buzz"); // Doesn't add "Buzz" value

            // Unit Test
            Assert.IsTrue(@this.Contains("Fizz"));
            Assert.IsFalse(@this.Contains("Buzz"));
        }
    }
}