// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_Try
    {
        [TestMethod]
        public void Try()
        {
            // Type
            var list = new List<int>();
            list.Add(1);

            // Exemples
            var result1 = list.Try(x => x[0]);
            var result2 = list.Try(x => x[1]);
            var result3 = list.Try(x => x[1], -1);
            int result10;
            int result11;
            int result12;
            var result7 = list.Try(x => x[0], out result10);
            var result8 = list.Try(x => x[1], out result11);
            var result9 = list.Try(x => x[1], -1, out result12);
            var result4 = list.Try(x => x[1], ints => -2);
            var result5 = list.Try(x => x.Add(2));
            var result6 = list.Try(x => { throw new Exception("exception!"); }, x => x.Add(3));


            // Unit Test
            Assert.AreEqual(1, result1);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(-1, result3);
            Assert.AreEqual(-2, result4);
            Assert.IsTrue(result5);
            Assert.IsFalse(result6);
            Assert.AreEqual(3, list.Count);
            Assert.IsTrue(result7);
            Assert.IsFalse(result8);
            Assert.IsFalse(result9);
            Assert.AreEqual(1, result10);
            Assert.AreEqual(0, result11);
            Assert.AreEqual(-1, result12);
        }
    }
}