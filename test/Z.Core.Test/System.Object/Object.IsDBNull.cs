using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_IsDBNull
    {
        [TestMethod]
        public void IsDBNull()
        {
            // Type
            object @thisDBNull = DBNull.Value;
            object @thisNull = null;

            // Examples
            bool result1 = @thisDBNull.IsDBNull(); // return true;
            bool result2 = @thisNull.IsDBNull(); // return false;

            // Unit Test
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}