using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Net.Test
{
    [TestClass]
    public class System_Net_WebResponse_ReadToEndAndDispose
    {
        [TestMethod]
        public void ReadToEndAndDispose()
        {
            WebRequest webRequest = WebRequest.Create("http://www.zzzportal.com/");

            // Type
            WebResponse @this = webRequest.GetResponseSafe();

            // Examples
            string value = @this.ReadToEndAndDispose();

            // Unit Test
            Assert.IsNotNull(value);
        }
    }
}