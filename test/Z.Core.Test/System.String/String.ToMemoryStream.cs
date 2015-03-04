// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ToMemoryStream
    {
        [TestMethod]
        public void ToMemoryStream()
        {
            // Type
            string @this = "FizzBuzz";

            // Examples
            using (Stream value = @this.ToMemoryStream()) // return a MemoryStream from the text
            {
                // Unit Test
                Assert.IsNotNull(value);
            }
        }
    }
}