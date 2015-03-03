using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_IsToday
    {
        [TestMethod]
        public void IsToday()
        {
            // Type
            DateTime @thisToday = DateTime.Today;
            DateTime @thisYesterday = @thisToday.AddDays(-1);

            // Exemples
            bool result1 = @thisToday.IsToday(); // return true;
            bool result2 = @thisYesterday.IsToday(); // return false;

            // Unit Test
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}