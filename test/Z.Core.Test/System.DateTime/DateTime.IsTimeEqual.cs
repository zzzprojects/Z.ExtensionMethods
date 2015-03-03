using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_IsTimeEqual
    {
        [TestMethod]
        public void IsTimeEqual()
        {
            // Type
            DateTime @thisToday = DateTime.Today;
            DateTime @thisYesterday = @thisToday.AddDays(-1);

            // Exemples
            bool result = @thisYesterday.IsTimeEqual(@thisToday); // return true;

            // Unit Test
            Assert.IsTrue(result);
        }
    }
}