using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_TimeSpan_Ago
    {
        [TestMethod]
        public void Ago()
        {
            // Type
            var @this = new TimeSpan(1, 0, 0, 0);

            // Examples
            DateTime value = @this.Ago(); // return yesterday.

            // Unit Test
            Assert.IsTrue(DateTime.Now.Subtract(value).Days >= 1);
        }
    }
}