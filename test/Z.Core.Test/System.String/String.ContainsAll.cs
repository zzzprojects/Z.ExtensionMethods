using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ContainsAll
    {
        [TestMethod]
        public void ContainsAll()
        {
            // Type
            string @this = "Fizz";

            // Examples
            bool value1 = @this.ContainsAll("F", "i"); // return true;
            bool value2 = @this.ContainsAll("F", "i", "Buzz"); // return false;
            bool value3 = @this.ContainsAll(StringComparison.InvariantCultureIgnoreCase, "f", "i"); // return true;
            bool value4 = @this.ContainsAll(StringComparison.InvariantCulture, "f", "i"); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
            Assert.IsTrue(value3);
            Assert.IsFalse(value4);
        }
    }
}