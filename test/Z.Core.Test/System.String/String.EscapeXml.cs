// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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