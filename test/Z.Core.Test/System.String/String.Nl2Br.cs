using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_Nl2Br
    {
        [TestMethod]
        public void Nl2Br()
        {
            // Type
            string @this = "Fizz" + Environment.NewLine + "Buzz";

            // Exemples
            string result = @this.Nl2Br(); // return "Fizz<br />Buzz";

            // Unit Test
            Assert.AreEqual("Fizz<br />Buzz", result);
        }
    }
}