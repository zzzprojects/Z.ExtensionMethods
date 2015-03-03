using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTimeOffset_SetTime
    {
        [TestMethod]
        public void SetTime()
        {
            // Type
            DateTimeOffset @thisToday = DateTimeOffset.Now;

            // Exemples
            DateTimeOffset result = @thisToday.SetTime(15); // Set hours to 15

            // Unit Test
            Assert.AreEqual(15, result.Hour);
        }
    }
}