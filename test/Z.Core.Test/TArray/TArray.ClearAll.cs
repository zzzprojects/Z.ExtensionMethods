using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class TArray_ClearAll
    {
        [TestMethod]
        public void ClearAll()
        {
            // Type
            var @this = new[] {"Fizz", "Buzz"};

            // Exemples
            @this.ClearAll(); // Remove all entries.

            // Unit Test
            Assert.AreEqual(null, @this[0]);
            Assert.AreEqual(null, @this[1]);
        }
    }
}