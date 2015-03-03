using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_RemoveLetter
    {
        [TestMethod]
        public void RemoveLetter()
        {
            // Type
            string @this = "Fizz1Buzz2";

            // Exemples
            string result = @this.RemoveLetter(); // return "12";

            // Unit Test
            Assert.AreEqual("12", result);
        }
    }
}