using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_ByteArray_Resize
    {
        [TestMethod]
        public void Resize()
        {
            // Type
            var @this = new Byte[1];
            @this[0] = 1;

            // Exemples
            @this = @this.Resize(4); // resize the array and keep value;

            // Unit Test
            Assert.AreEqual(1, @this[0]);
            Assert.AreEqual(4, @this.Length);
        }
    }
}