using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_ShallowCopy
    {
        [TestMethod]
        public void ShallowCopy()
        {
            // Type
            var @this = new TestClass {Value = "Fizz"};

            // Exemples
            TestClass clone = @this.ShallowCopy(); // return a shallow copy;

            // Unit Test
            Assert.AreEqual(@this.Value, clone.Value);
        }

        [Serializable]
        public class TestClass
        {
            public string Value;
        }
    }
}