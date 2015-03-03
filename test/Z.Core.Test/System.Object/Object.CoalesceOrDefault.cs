using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_CoalesceOrDefault
    {
        [TestMethod]
        public void CoalesceOrDefault()
        {
            // Varable
            object nullObject = null;

            // Type
            object @thisNull = null;
            object @thisNotNull = "Fizz";

            // Exemples
            object result1 = @thisNull.CoalesceOrDefault(nullObject, nullObject, "Buzz"); // return "Buzz";
            object result2 = @thisNull.CoalesceOrDefault(() => "Buzz", null, null); // return "Buzz";
            object result3 = @thisNull.CoalesceOrDefault(x => "Buzz", null, null); // return "Buzz";
            object result4 = @thisNotNull.CoalesceOrDefault(nullObject, nullObject, "Buzz"); // return "Fizz";

            // Unit Test
            Assert.AreEqual("Buzz", result1);
            Assert.AreEqual("Buzz", result2);
            Assert.AreEqual("Buzz", result3);
            Assert.AreEqual("Fizz", result4);
        }
    }
}