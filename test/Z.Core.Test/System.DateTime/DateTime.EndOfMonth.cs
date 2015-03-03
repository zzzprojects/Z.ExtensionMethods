using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_EndOfMonth
    {
        [TestMethod]
        public void EndOfMonth()
        {
            // Type
            var @this = new DateTime(2013, 12, 22);

            // Examples
            DateTime value = @this.EndOfMonth(); // value = "2013/12/31 23:59:59:999";

            // Unit Test
            Assert.AreEqual(new DateTime(2013, 12, 31, 23, 59, 59, 999), value);
        }
    }
}