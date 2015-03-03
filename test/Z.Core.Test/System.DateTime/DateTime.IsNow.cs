using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_IsNow
    {
        [TestMethod]
        public void IsNow()
        {
            // Type
            DateTime @this = DateTime.Now;

            // Examples
            bool value1 = @this.IsNow();

            // Unit Test
        }
    }
}