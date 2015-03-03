using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_PathCombine
    {
        [TestMethod]
        public void PathCombine()
        {
            // Type
            string @this = "FizzBuzz";

            string path1 = "Fizz";
            string path2 = "Buzz";

            // Exemples
            string result = @this.PathCombine(path1, path2); // Combine path1 and path2 with the @this

            // Unit Test
            Assert.AreEqual(Path.Combine("FizzBuzz", path1, path2), result);
        }
    }
}