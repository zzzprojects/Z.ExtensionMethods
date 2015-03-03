using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ReplaceByEmpty
    {
        [TestMethod]
        public void ReplaceByEmpty()
        {
            // Type
            string @this = "FizzBuzz";

            // Examples
            string value = @this.ReplaceByEmpty("z"); // return "FiBu";

            // Unit Test
            Assert.AreEqual("FiBu", value);
        }
    }
}