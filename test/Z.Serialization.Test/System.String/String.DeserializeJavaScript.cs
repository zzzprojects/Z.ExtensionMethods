using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Serialization.Test
{
    [TestClass]
    public class System_String_DeserializeJavaScript
    {
        [TestMethod]
        public void DeserializeJavaScript()
        {
            // Type
            string @this = "[\"Fizz\",\"Buzz\"]";

            // Examples
            var result = @this.DeserializeJavaScript<List<string>>();

            // Unit Test
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Fizz", result[0]);
            Assert.AreEqual("Buzz", result[1]);

            var product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Sizes = new[] {"Small"};

            // Serialize
            string resultProduct = product.SerializeJavaScript();

            // Deserialize
            var product2 = resultProduct.DeserializeJavaScript<Product>();

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