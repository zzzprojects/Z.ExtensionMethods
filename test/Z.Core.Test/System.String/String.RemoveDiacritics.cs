using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_RemoveDiacritics
    {
        [TestMethod]
        public void RemoveDiacritics()
        {
            // Type
            string @this = "éèêôîâ";

            // Examples
            string value = @this.RemoveDiacritics(); // return "eeeoia";

            // Unit Test
            Assert.AreEqual("eeeoia", value);
        }
    }
}