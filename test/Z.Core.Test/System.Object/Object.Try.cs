// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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