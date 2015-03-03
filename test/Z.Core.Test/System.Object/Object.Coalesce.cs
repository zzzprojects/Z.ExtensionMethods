using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_Coalesce
    {
        [TestMethod]
        public void Coalesce()
        {
            // Type
            object @thisNull = null;
            object @thisNotNull = "Fizz";

            // Exemples
            object result1 = @thisNull.Coalesce(null, null, "Fizz", "Buzz"); // return "Fizz";
            object result2 = @thisNull.Coalesce(null, "Fizz", null, "Buzz"); // return "Fizz";
            object result3 = @thisNotNull.Coalesce(null, null, null, "Buzz"); // return "Fizz";

            // Unit Test
            Assert.AreEqual("Fizz", result1);
            Assert.AreEqual("Fizz", result2);
            Assert.AreEqual("Fizz", result3);
        }
    }
}