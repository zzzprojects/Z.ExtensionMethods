using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_RemoveIf
    {
        [TestMethod]
        public void RemoveIf()
        {
            // Type
            var @this = new List<string> {"zA", "zB", "C"};

            // Exemples
            @this.RemoveIf("zA", @this.Contains); // Remove "zA" items

            // Unit Test
            Assert.AreEqual(2, @this.Count);
        }
    }
}