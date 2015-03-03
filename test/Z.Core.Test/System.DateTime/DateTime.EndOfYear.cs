using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_EndOfYear
    {
        [TestMethod]
        public void EndOfYear()
        {
            // Type
            var @this = new DateTime(2013, 04, 13);

            // Examples
            DateTime value = @this.EndOfYear(); // value = "2013/12/31 23:59:59:999";

            // Unit Test
            Assert.AreEqual(new DateTime(2013, 12, 31, 23, 59, 59, 999), value);
        }
    }
}