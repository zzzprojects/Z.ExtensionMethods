using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Compression.Test
{
    [TestClass]
    public class System_ByteArray_DecompressGZip
    {
        [TestMethod]
        public void DecompressGZip()
        {
            // Type
            byte[] @this = "FizzBuzz".CompressGZip();

            // Exemples
            string result = @this.DecompressGZip(); // return "FizzBuzz";

            // Unit Test
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}