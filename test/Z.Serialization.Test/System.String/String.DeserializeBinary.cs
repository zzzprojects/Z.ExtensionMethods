using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Serialization.Test
{
    [TestClass]
    public class System_String_DeserializeBinary
    {
        [TestMethod]
        public void DeserializeBinary()
        {
            // Type
            var @this = new Dictionary<string, string> {{"Fizz", "Buzz"}};
            string s = @this.SerializeBinary();

            // Examples
            var value = s.DeserializeBinary<Dictionary<string, string>>(); // return new Dictionary<string, string> {{"Fizz", "Buzz"}};

            // Unit Test
            Assert.AreEqual("Buzz", value["Fizz"]);

            var product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Sizes = new[] {"Small"};

            // Serialize
            string resultProduct = product.SerializeBinary();

            // Deserialize
            var product2 = resultProduct.DeserializeBinary<Product>();

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