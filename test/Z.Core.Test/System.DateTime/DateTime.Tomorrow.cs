using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_Tomorrow
    {
        [TestMethod]
        public void Tomorrow()
        {
            // Type
            DateTime @this = DateTime.Now;

            // Exemples
            DateTime result = @this.Tomorrow(); // Return date as tomorrow

            // Unit Test
            Assert.AreEqual(@this.AddDays(1).Day, result.Day);
        }
    }
}