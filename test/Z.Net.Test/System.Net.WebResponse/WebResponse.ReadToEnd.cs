// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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