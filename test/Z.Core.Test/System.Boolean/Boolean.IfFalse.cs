using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Boolean_IfFalse
    {
        [TestMethod]
        public void IfFalse()
        {
            // Variables
            string value1 = "";
            string value2 = "";

            // Type
            const bool conditionTrue = true;
            const bool conditionFalse = false;

            // Examples
            conditionTrue.IfFalse(() => value1 = "FizzBuzz"); // value1 = "";
            conditionFalse.IfFalse(() => value2 = "FizzBuzz"); // value2 = "FizzBuzz";

            // Unit Test
            Assert.AreEqual("", value1);
            Assert.AreEqual("FizzBuzz", value2);
        }
    }
}