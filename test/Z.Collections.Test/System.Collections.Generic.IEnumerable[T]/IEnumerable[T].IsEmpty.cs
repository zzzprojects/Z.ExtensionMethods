using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_IEnumerable_T_IsEmpty
    {
        [TestMethod]
        public void IsEmpty()
        {
            // Type
            IEnumerable<string> @thisEmpty = new List<string>().AsEnumerable();
            IEnumerable<string> @thisNotEmpty = new List<string> {"Fizz"}.AsEnumerable();

            // Exemples
            bool result2 = @thisEmpty.IsEmpty(); // return true;
            bool result3 = @thisNotEmpty.IsEmpty(); // return false;

            // Unit Test
            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
        }
    }
}