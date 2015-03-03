using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Guid_IsEmpty
    {
        [TestMethod]
        public void IsEmpty()
        {
            // Type
            Guid guidEmpty = Guid.Empty;
            Guid guidValue = Guid.NewGuid();

            // Unit Test
            Assert.IsTrue(guidEmpty.IsEmpty());
            Assert.IsFalse(guidValue.IsEmpty());
        }
    }
}