// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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