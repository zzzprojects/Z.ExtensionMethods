using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_EncodeBase64
    {
        [TestMethod]
        public void EncodeBase64()
        {
            // Type
            string @this = "Rml6eg==";

            // Examples
            string value = @this.DecodeBase64(); // return "Fizz";

            // Unit Test
            Assert.AreEqual("Fizz", value);
        }
    }
}