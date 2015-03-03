using System.IO;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Web.Test
{
    [TestClass]
    public class System_Web_HttpResponse_SendAttachment
    {
        [TestMethod]
        public void SendAttachment()
        {
            var writer = new StringWriter();

            // Type
            var @this = new HttpResponse(writer);

            // Examples
            try
            {
                @this.SendAttachment("myfilepath", "outputFileName");
            }
            catch
            {
            }
        }
    }
}