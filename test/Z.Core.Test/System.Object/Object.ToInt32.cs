using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_ToInt32
    {
        [TestMethod]
        public void ToInt32()
        {
            // Type
            string @this = "32";

            // Exemples
            int result = @this.ToInt32(); // return 32;

            // Unit Test
            Assert.AreEqual(32, result);
        }
    }
}