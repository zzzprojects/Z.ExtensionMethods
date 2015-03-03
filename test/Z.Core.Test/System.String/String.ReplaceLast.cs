using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ReplaceLast
    {
        [TestMethod]
        public void ReplaceLast()
        {
            // Type
            string @this = "zzzzz";

            // Exemples
            string result1 = @this.ReplaceLast("z", "a"); // return "zzzza";
            string result2 = @this.ReplaceLast(3, "z", "a"); // return "zzaaa";
            string result3 = @this.ReplaceLast(3, "z", "za"); // return "zzzazaza";
            string result4 = @this.ReplaceLast(4, "z", "a"); // return "zaaaa";
            string result5 = @this.ReplaceLast(5, "z", "a"); // return "aaaaa";
            string result6 = @this.ReplaceLast(10, "z", "a"); // return "aaaaa";

            // Unit Test
            Assert.AreEqual("zzzza", result1);
            Assert.AreEqual("zzaaa", result2);
            Assert.AreEqual("zzzazaza", result3);
            Assert.AreEqual("zaaaa", result4);
            Assert.AreEqual("aaaaa", result5);
            Assert.AreEqual("aaaaa", result6);
        }
    }
}