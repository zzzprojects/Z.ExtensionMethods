using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Boolean_IfTrue
    {
        [TestMethod]
        public void IfTrue()
        {
            // Variables
            string value1 = "";
            string value2 = "";

            // Type
            const bool conditionTrue = true;
            const bool conditionFalse = false;

            // Examples
            conditionTrue.IfTrue(() => value1 = "FizzBuzz"); // value1 = "FizzBuzz";
            conditionFalse.IfTrue(() => value2 = "FizzBuzz"); // value2 = "";

            // Unit Test
            Assert.AreEqual("FizzBuzz", value1);
            Assert.AreEqual("", value2);
        }
    }
}