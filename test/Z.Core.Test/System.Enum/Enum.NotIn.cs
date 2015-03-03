using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Enum_NotIn
    {
        [TestMethod]
        public void NotIn()
        {
            // Type
            var @this = Environment.SpecialFolder.Desktop;

            // Exemples
            bool result1 = @this.NotIn(Environment.SpecialFolder.Desktop, Environment.SpecialFolder.DesktopDirectory); // return false;
            bool result2 = @this.NotIn(Environment.SpecialFolder.DesktopDirectory); // return true;

            // Unit Test
            Assert.IsFalse(result1);
            Assert.IsTrue(result2);
        }
    }
}