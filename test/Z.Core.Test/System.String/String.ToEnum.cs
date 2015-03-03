using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ToEnum
    {
        [TestMethod]
        public void ToEnum()
        {
            // Type
            string @this = "Ordinal";

            // Examples
            var value = @this.ToEnum<StringComparison>(); // return StringComparison.Ordinal;

            // Unit Test
            Assert.AreEqual(StringComparison.Ordinal, value);
        }
    }
}