using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_RemoveRangeIf
    {
        [TestMethod]
        public void RemoveRangeIf()
        {
            // Type
            var @this = new List<string> {"zA", "zB", "C"};

            // Exemples
            @this.RemoveRangeIf(x => x.StartsWith("z"), "zA", "zB", "C"); // Remove all items starting by "z"

            // Unit Test
            Assert.AreEqual(1, @this.Count);
        }
    }
}