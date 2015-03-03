using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_RemoveRangeIfContains
    {
        [TestMethod]
        public void RemoveRangeIfContains()
        {
            // Type
            var @this = new List<string> {"zA", "zB", "C"};

            // Exemples
            @this.RemoveRangeIfContains("zA", "D"); // Remove "zA" item

            // Unit Test
            Assert.AreEqual(2, @this.Count);
        }
    }
}