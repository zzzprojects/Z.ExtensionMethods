using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_EscapeXml
    {
        [TestMethod]
        public void EscapeXml()
        {
            // Type
            string @this = "<node>it's my \"node\" & i like it<node>";

            // Exemples
            string result = @this.EscapeXml(); // return "&lt;node&gt;it&apos;s my &quot;node&quot; &amp; i like it&lt;node&gt;";

            // Unit Test
            Assert.AreEqual("&lt;node&gt;it&apos;s my &quot;node&quot; &amp; i like it&lt;node&gt;", result);
        }
    }
}