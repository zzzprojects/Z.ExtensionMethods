using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_ContainsAny
    {
        [TestMethod]
        public void ContainsAny()
        {
            // Type
            var @this = new List<string> {"zA", "zB", "C"};

            // Exemples
            bool value1 = @this.ContainsAny("1", "zA", "3"); // return true;
            bool value2 = @this.ContainsAny("1", "2", "3"); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}