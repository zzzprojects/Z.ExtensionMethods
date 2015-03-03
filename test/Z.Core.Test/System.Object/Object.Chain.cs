using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_Chain
    {
        [TestMethod]
        public void Chain()
        {
            // Type
            var @this = new List<string>();

            // Exemples
            @this.Chain(x => x.Add("Fizz"))
                .Chain(x => x.Add("Buzz"))
                .Chain(x => x.Add("FizzBuzz")); // Chain multiple action

            // Unit Test
            Assert.AreEqual(3, @this.Count);
        }
    }
}