// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Net.Test
{
    [TestClass]
    public class System_Net_WebRequest_GetResponseSafe
    {
        [TestMethod]
        public void GetResponseSafe()
        {
            // Type
            WebRequest @this = WebRequest.Create("http://www.zzzportal.com/");

            // Examples
            WebResponse value = @this.GetResponseSafe(); // return a response;

            // Unit Test
            Assert.IsNotNull(value);
        }
    }
}