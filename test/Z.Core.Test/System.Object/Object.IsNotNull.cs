using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_IsNotNull
    {
        [TestMethod]
        public void IsNotNull()
        {
            // Type
            object @thisNull = null;
            var @thisNotNull = new object();

            // Examples
            bool value1 = @thisNull.IsNotNull(); // return false;
            bool value2 = @thisNotNull.IsNotNull(); // return true;

            // Unit Test
            Assert.IsFalse(value1);
            Assert.IsTrue(value2);
        }
    }
}