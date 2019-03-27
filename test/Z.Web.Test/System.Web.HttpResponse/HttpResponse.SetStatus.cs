// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.IO;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Web.Test
{
    [TestClass]
    public class System_Web_HttpResponse_SetStatus
    {
        [TestMethod]
        public void SetStatus()
        {
            var writer = new StringWriter();

            // Type
            var @this = new HttpResponse(writer);

            // Examples
            @this.SetStatus(200, "FizzBuzz", false);

            // UnitTest
            Assert.AreEqual(200, @this.StatusCode);
            Assert.AreEqual("FizzBuzz", @this.StatusDescription);
        }
    }
}