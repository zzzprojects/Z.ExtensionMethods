using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_ContainsAll
    {
        [TestMethod]
        public void ContainsAll()
        {
            // Type
            var @this = new List<string> {"zA", "zB", "C"};

            // Exemples
            bool value1 = @this.ContainsAll("zA", "zB"); // return true;
            bool value2 = @this.ContainsAll("zA", "2"); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}