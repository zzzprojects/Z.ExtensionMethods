using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Boolean_ToBinary
    {
        [TestMethod]
        public void ToBinary()
        {
            // Type
            bool @thisTrue = true;
            bool @thisFalse = false;

            // Exemples
            byte result1 = @thisTrue.ToBinary(); // return 1;
            byte result2 = @thisFalse.ToBinary(); // return 0;

            // Unit Test
            Assert.AreEqual(1, result1);
            Assert.AreEqual(0, result2);
        }
    }
}