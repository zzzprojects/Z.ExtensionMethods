using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_RemoveIfContains
    {
        [TestMethod]
        public void RemoveIfContains()
        {
            // Type
            var @this = new List<string> {"zA", "zB", "C"};

            // Exemples
            @this.RemoveIfContains("zA"); // Remove "zA" items

            // Unit Test
            Assert.AreEqual(2, @this.Count);
        }
    }
}