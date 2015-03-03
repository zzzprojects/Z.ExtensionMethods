using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_NullIf
    {
        [TestMethod]
        public void NullIf()
        {
            // Type
            string @this = "1";

            // Exemples
            string result1 = @this.NullIf(x => x == "1"); // return null;
            string result2 = @this.NullIf(x => x == "2"); // return "1";

            // Unit Test
            Assert.AreEqual(null, result1);
            Assert.AreEqual("1", result2);
        }
    }
}