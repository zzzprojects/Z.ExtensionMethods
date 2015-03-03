using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_FirstDayOfWeek
    {
        [TestMethod]
        public void FirstDayOfWeek()
        {
            // Type
            var @this = new DateTime(2014, 04, 16);

            // Exemples
            DateTime result = @this.FirstDayOfWeek(); // result = "2013/04/13";

            // Unit Test
            Assert.AreEqual(new DateTime(2014, 04, 13), result);
        }
    }
}