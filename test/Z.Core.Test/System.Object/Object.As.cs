using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_As
    {
        [TestMethod]
        public void As()
        {
            // Type
            var intObject = (object) 13;
            var stringObject = (object) "FizzBuzz";
            var arrayObject = (object) new[] {"Fizz", "Buzz"};

            // Exemples
            var intValue = intObject.As<int>(); // return 13;
            var stringValue = stringObject.As<string>(); // return "FizzBuzz";
            int arrayCount = arrayObject.As<string[]>().Length; // return 2;

            // Unit Test
            Assert.AreEqual(13, intValue);
            Assert.AreEqual("FizzBuzz", stringValue);
            Assert.AreEqual(2, arrayCount);
        }
    }
}