using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_IsNull
    {
        [TestMethod]
        public void IsNull()
        {
            // Type
            object @thisNull = null;
            var @thisNotNull = new object();

            // Examples
            bool value1 = @thisNull.IsNull(); // return true;
            bool value2 = @thisNotNull.IsNull(); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}