using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ToTitleCase
    {
        [TestMethod]
        public void ToTitleCase()
        {
            // Type
            string @this = "fizz buzz";

            // Exemples
            string result = @this.ToTitleCase(); // return "Fizz Buzz";

            // Unit Test
            Assert.AreEqual("Fizz Buzz", result);
        }
    }
}