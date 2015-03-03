using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_IEnumerable_T_IsNotEmpty
    {
        [TestMethod]
        public void IsNotEmpty()
        {
            // Type
            IEnumerable<string> @thisEmpty = new List<string>().AsEnumerable();
            IEnumerable<string> @thisNotEmpty = new List<string> {"Fizz"}.AsEnumerable();

            // Exemples
            bool result2 = @thisEmpty.IsNotEmpty(); // return false;
            bool result3 = @thisNotEmpty.IsNotEmpty(); // return true;

            // Unit Test
            Assert.IsFalse(result2);
            Assert.IsTrue(result3);
        }
    }
}