using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_RemoveWhere
    {
        [TestMethod]
        public void RemoveWhere()
        {
            // Type
            var @this = new List<string> {"zA", "zB", "C"};

            // Exemples
            @this.RemoveWhere(x => x.StartsWith("z")); // Remove all items starting by "z"

            // Unit Test
            Assert.AreEqual(1, @this.Count);
        }
    }
}