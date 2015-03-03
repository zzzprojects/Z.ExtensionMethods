using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ContainsAny
    {
        [TestMethod]
        public void ContainsAny()
        {
            // Type
            string @this = "Fizz";

            // Examples
            bool value1 = @this.ContainsAny("F", "Buzz"); // value = ";
            bool value2 = @this.ContainsAny("Bizz", "Buzz"); // value = ";
            bool value3 = @this.ContainsAny(StringComparison.InvariantCultureIgnoreCase, "f", "Buzz"); // value = ";
            bool value4 = @this.ContainsAny(StringComparison.InvariantCulture, "f", "Buzz"); // value = ";

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
            Assert.IsTrue(value3);
            Assert.IsFalse(value4);
        }
    }
}