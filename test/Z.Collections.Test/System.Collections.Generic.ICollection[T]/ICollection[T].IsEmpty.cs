using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_IsEmpty
    {
        [TestMethod]
        public void IsEmpty()
        {
            // Type
            var @this = new List<string>();

            // Examples
            bool value1 = @this.IsEmpty(); // return true;

            @this.Add("Fizz");
            bool value2 = @this.IsEmpty(); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}