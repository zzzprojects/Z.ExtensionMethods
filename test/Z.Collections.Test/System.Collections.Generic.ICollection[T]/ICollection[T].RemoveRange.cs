using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_RemoveRange
    {
        [TestMethod]
        public void RemoveRange()
        {
            // Type
            var @this = new List<string> {"zA", "zB", "C"};

            // Exemples
            @this.RemoveRange("zA", "zB"); // Remove "zA" and "zB" items

            // Unit Test
            Assert.AreEqual(1, @this.Count);
        }
    }
}