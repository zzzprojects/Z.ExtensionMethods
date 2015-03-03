using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_SetTime
    {
        [TestMethod]
        public void SetTime()
        {
            // Type
            DateTime @thisToday = DateTime.Today;

            // Exemples
            DateTime result = @thisToday.SetTime(15); // Set hours to 15

            // Unit Test
            Assert.AreEqual(15, result.Hour);
        }
    }
}