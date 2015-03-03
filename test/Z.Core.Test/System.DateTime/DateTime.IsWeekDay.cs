using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_IsWeekDay
    {
        [TestMethod]
        public void IsWeekDay()
        {
            // Type
            var @thisFriday = new DateTime(2013, 11, 22); // Friday
            var @thisSaturday = new DateTime(2013, 11, 23); // Saturday

            // Examples
            bool value1 = @thisFriday.IsWeekDay(); // return true;
            bool value2 = @thisSaturday.IsWeekDay(); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}