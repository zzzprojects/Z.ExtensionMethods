using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Array_WithinIndex
    {
        [TestMethod]
        public void WithinIndex()
        {
            // Type
            Array @this = new[] {"Fizz", "Buzz"};

            // Exemples
            bool result1 = @this.WithinIndex(1); // return true;
            bool result2 = @this.WithinIndex(2); // return false;

            // Unit Test
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}