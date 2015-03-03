using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_IsNotEmpty
    {
        [TestMethod]
        public void IsNotEmpty()
        {
            // Type
            var @this = new List<string>();

            // Examples
            bool value1 = @this.IsNotEmpty(); // return false;

            @this.Add("Fizz");
            bool value2 = @this.IsNotEmpty(); // return true;

            // Unit Test
            Assert.IsFalse(value1);
            Assert.IsTrue(value2);
        }
    }
}