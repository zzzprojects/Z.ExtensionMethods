using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ToMemoryStream
    {
        [TestMethod]
        public void ToMemoryStream()
        {
            // Type
            string @this = "FizzBuzz";

            // Examples
            using (Stream value = @this.ToMemoryStream()) // return a MemoryStream from the text
            {
                // Unit Test
                Assert.IsNotNull(value);
            }
        }
    }
}