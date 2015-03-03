using System.IO;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Web.Test
{
    [TestClass]
    public class System_Web_HttpResponse_Reload
    {
        [TestMethod]
        public void Reload()
        {
            var writer = new StringWriter();

            // Type
            var @this = new HttpResponse(writer);

            // Examples
            try
            {
                @this.Reload();
            }
            catch
            {
            }
        }
    }
}