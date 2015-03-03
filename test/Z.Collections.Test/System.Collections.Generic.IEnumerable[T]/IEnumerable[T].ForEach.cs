using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_IEnumerable_T_ForEach
    {
        [TestMethod]
        public void ForEach()
        {
            string result = "";
            // Type
            IEnumerable<string> @this = new List<string> {"zA", "zB", "C"}.AsEnumerable();

            // Exemples
            @this.ForEach(s => result += s);

            // Unit Test
            Assert.AreEqual("zAzBC", result);
        }
    }
}