// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Caching.Test
{
    [TestClass]
    public class Object
    {
        [TestMethod]
        public void FromCache()
        {
            var cache1 = new CacheTest();
            var cache2 = new CacheTest();

            int cache1_1 = cache1.FromCache(i => cache1.Increment());
            int cache1_2 = cache1.FromCache(i => cache1.Increment());

            int cache2_1 = cache1.FromCache("CustomKey", i => cache2.Increment());
            int cache2_2 = cache1.FromCache("CustomKey", i => cache2.Increment());

            int cache3_1 = cache1.FromCache("CustomKeyWithValue", 1);
            int cache3_2 = cache1.FromCache("CustomKeyWithValue", 2);

            Assert.AreEqual(1, cache1_1);
            Assert.AreEqual(1, cache1_2);

            Assert.AreEqual(1, cache2_1);
            Assert.AreEqual(1, cache2_2);

            Assert.AreEqual(1, cache3_1);
            Assert.AreEqual(1, cache3_2);
        }

        public class CacheTest
        {
            public int Cache = 0;

            public int Increment()
            {
                Cache++;
                return Cache;
            }
        }
    }
}