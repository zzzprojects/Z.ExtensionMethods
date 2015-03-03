using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ReplaceFirst
    {
        [TestMethod]
        public void ReplaceFirst()
        {
            // Type
            string @this = "zzzzz";

            // Exemples
            string result1 = @this.ReplaceFirst("z", "a"); // return "azzzz";
            string result2 = @this.ReplaceFirst(3, "z", "a"); // return "aaazz";
            string result3 = @this.ReplaceFirst(3, "z", "za"); // return "zazazazz";
            string result4 = @this.ReplaceFirst(4, "z", "a"); // return "aaaaz";
            string result5 = @this.ReplaceFirst(5, "z", "a"); // return "aaaaa";
            string result6 = @this.ReplaceFirst(10, "z", "a"); // return "aaaaa";

            // Unit Test
            Assert.AreEqual("azzzz", result1);
            Assert.AreEqual("aaazz", result2);
            Assert.AreEqual("zazazazz", result3);
            Assert.AreEqual("aaaaz", result4);
            Assert.AreEqual("aaaaa", result5);
            Assert.AreEqual("aaaaa", result6);
        }
    }
}