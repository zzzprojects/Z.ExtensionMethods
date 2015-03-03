using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_Contains
    {
        [TestMethod]
        public void Contains()
        {
            // Type
            string @this = "Fizz";

            // Examples
            bool value1 = @this.Contains("f", StringComparison.InvariantCultureIgnoreCase); // return true;
            bool value2 = @this.Contains("f", StringComparison.InvariantCulture); // return false;
            bool value3 = @this.Contains("F"); // return true;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
            Assert.IsTrue(value3);
        }
    }
}