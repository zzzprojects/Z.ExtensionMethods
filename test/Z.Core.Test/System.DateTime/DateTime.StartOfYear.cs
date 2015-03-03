using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_StartOfYear
    {
        [TestMethod]
        public void StartOfYear()
        {
            // Type
            DateTime @this = DateTime.Now;

            // Examples
            DateTime value = @this.StartOfYear(); // value = "yyyy/01/01 00:00:00:000";

            // Unit Test
            Assert.AreEqual(new DateTime(value.Year, 1, 1), value);
        }
    }
}