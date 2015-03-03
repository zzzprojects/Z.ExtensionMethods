using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_IsLike
    {
        [TestMethod]
        public void IsLike()
        {
            // Type
            string @this = "FizzBuzz3";

            // Examples
            bool value1 = @this.IsLike("Fizz*"); // return true;
            bool value2 = @this.IsLike("*zzB*"); // return true;
            bool value3 = @this.IsLike("*Buzz#"); // return true;
            bool value4 = @this.IsLike("*zz?u*"); // return true;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsTrue(value2);
            Assert.IsTrue(value3);
            Assert.IsTrue(value4);
        }
    }
}