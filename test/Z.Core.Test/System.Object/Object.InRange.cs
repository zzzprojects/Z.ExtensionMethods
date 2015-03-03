using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_InRange
    {
        [TestMethod]
        public void InRange()
        {
            // Type
            int @this = 3;

            // Examples
            bool value1 = @this.InRange(-4, 3); // return true;
            bool value2 = @this.InRange(10, 100); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}