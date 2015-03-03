using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_NullIfEmpty
    {
        [TestMethod]
        public void NullIfEmpty()
        {
            // Type
            string @this = "";

            // Examples
            string value = @this.NullIfEmpty(); // return null;

            // Unit Test
            Assert.IsNull(value);
        }
    }
}