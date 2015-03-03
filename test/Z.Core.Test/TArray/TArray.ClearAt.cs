using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class TArray_ClearAt
    {
        [TestMethod]
        public void ClearAt()
        {
            // Type
            var @this = new[] {"Fizz", "Buzz"};

            // Exemples
            @this.ClearAt(0); // Clear index 0;

            // Unit Test
            Assert.AreEqual(null, @this[0]);
            Assert.AreEqual("Buzz", @this[1]);
        }
    }
}