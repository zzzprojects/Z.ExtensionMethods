using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_Left
    {
        [TestMethod]
        public void Left()
        {
            // Type
            string @this = "Fizz";

            // Examples
            string value = @this.Left(2); // return "Fi";

            // Unit Test
            Assert.AreEqual("Fi", value);
        }
    }
}