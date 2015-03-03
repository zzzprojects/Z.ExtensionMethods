using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_TimeSpan_UtcFromNow
    {
        [TestMethod]
        public void UtcFromNow()
        {
            // Type
            var @this = new TimeSpan(1, 0, 0, 0);

            // Examples
            DateTime value = @this.UtcFromNow(); // return yesterday.

            // Unit Test
            Assert.IsTrue(DateTime.UtcNow.Subtract(value).Days <= -1);
        }
    }
}