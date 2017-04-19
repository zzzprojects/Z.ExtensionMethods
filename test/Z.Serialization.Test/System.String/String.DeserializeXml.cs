// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Serialization.Test
{
    [TestClass]
    public class System_String_DeserializeXml
    {
        [TestMethod]
        public void DeserializeXml()
        {
            // Type
            string @this = "<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>Fizz</string>\r\n  <string>Buzz</string>\r\n</ArrayOfString>";

            // Examples
            var value = @this.DeserializeXml<List<string>>(); // new List<string> {"Fizz", "Buzz"};

            // Unit Test
            Assert.AreEqual("Fizz", value[0]);

            var product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Sizes = new[] {"Small"};

            // Serialize
            string resultProduct = product.SerializeXml();

            // Deserialize
            var product2 = resultProduct.DeserializeXml<Product>();

            // Unit Test
            Assert.AreEqual("Apple", product2.Name);
            Assert.AreEqual(new DateTime(2008, 12, 28).Date, product2.Expiry.Date);
            Assert.AreEqual("Small", product2.Sizes[0]);
        }

        [Serializable]
        public class Product
        {
            public DateTime Expiry;
            public string Name;
            public string[] Sizes;
        }
    }
}