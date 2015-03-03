using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_Truncate
    {
        [TestMethod]
        public void Truncate()
        {
            // Type
            string @this = "123456789";

            // Exemples
            string result = @this.Truncate(6); // return "123...";

            // Unit Test
            Assert.AreEqual("123...", result);
        }
    }
}