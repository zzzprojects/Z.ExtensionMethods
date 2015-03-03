using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_IsAfternoon
    {
        [TestMethod]
        public void IsAfternoon()
        {
            // Type
            var @thisMorning = new DateTime(2014, 04, 12, 8, 0, 0);
            var @thisAfternoon = new DateTime(2014, 04, 12, 17, 0, 0);


            // Exemples
            bool result1 = @thisMorning.IsAfternoon(); // return false;
            bool result2 = @thisAfternoon.IsAfternoon(); // return true;

            // Unit Test
            Assert.IsFalse(result1);
            Assert.IsTrue(result2);
        }
    }
}