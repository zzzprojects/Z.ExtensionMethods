using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_StartOfWeek
    {
        [TestMethod]
        public void StartOfWeek()
        {
            // Type
            var @this = new DateTime(2014, 04, 16);

            // Examples
            DateTime value = @this.StartOfWeek(); // value = "2013/04/13 00:00:00:000";

            // Unit Test
            Assert.AreEqual(new DateTime(2014, 04, 13), value);
        }
    }
}