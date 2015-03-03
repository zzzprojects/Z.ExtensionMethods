using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_LastDayOfWeek
    {
        [TestMethod]
        public void LastDayOfWeek()
        {
            // Type
            var @this = new DateTime(2014, 01, 24);

            // Exemples
            DateTime result = @this.LastDayOfWeek(); // return "2014/01/25";

            // Unit Test
            Assert.AreEqual(new DateTime(2014, 01, 25), result.Date);
        }
    }
}