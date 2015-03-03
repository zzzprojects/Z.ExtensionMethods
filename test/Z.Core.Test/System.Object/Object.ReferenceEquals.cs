using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_ReferenceEquals
    {
        [TestMethod]
        public void ReferenceEquals()
        {
            // Type
            string @this = null;

            // Examples
            bool result1 = @this.ReferenceEquals(null); // return true;
            bool result2 = @this.ReferenceEquals(""); // return false;

            // Unit Test
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}