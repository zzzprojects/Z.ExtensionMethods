// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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