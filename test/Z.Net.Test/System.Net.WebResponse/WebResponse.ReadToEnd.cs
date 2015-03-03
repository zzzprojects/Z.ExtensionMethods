using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Net.Test
{
    [TestClass]
    public class System_Net_WebResponse_ReadToEnd
    {
        [TestMethod]
        public void ReadToEnd()
        {
            WebRequest webRequest = WebRequest.Create("http://www.zzzportal.com/");

            // Type
            WebResponse @this = webRequest.GetResponseSafe();

            // Examples
            string value = null;
            using (@this)
            {
                value = @this.ReadToEnd();
            }

            // Unit Test
            Assert.IsNotNull(value);
        }
    }
}