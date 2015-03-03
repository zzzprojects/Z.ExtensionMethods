using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Double_ToMoney
    {
        [TestMethod]
        public void ToMoney()
        {
            // Type
            double @this1 = 2.311;
            double @this2 = 2.3191;

            // Exemples
            double result1 = @this1.ToMoney(); // return 2.31;
            double result2 = @this2.ToMoney(); // return 2.32;

            // Unit Test
            Assert.AreEqual(2.31, result1);
            Assert.AreEqual(2.32, result2);
        }
    }
}