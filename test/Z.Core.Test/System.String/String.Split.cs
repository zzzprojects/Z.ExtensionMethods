using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_Split
    {
        [TestMethod]
        public void Split()
        {
            // Type
            string @this = "FizzBuzz";

            // Examples
            string[] value = @this.Split("B"); // return new[] {"Fizz", "uzz"}

            // Unit Test
            Assert.AreEqual("Fizz", value[0]);
            Assert.AreEqual("uzz", value[1]);
        }
    }
}