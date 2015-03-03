using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_Repeat
    {
        [TestMethod]
        public void Repeat()
        {
            // Type
            string @this = "Fizz";

            // Examples
            string value = @this.Repeat(3); // return "FizzFizzFizz";

            // Unit Test
            Assert.AreEqual("FizzFizzFizz", value);
        }
    }
}