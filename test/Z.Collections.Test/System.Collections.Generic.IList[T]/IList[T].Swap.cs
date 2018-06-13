// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_IList_T_Swap
    {
        [TestMethod]
        public void Swap()
        {
            // Type
            var stringList = new List<string>();
            stringList.AddRange("Foo", "Bar", "Baz");

            // Examples
            var example1 = new List<string>(stringList);
            example1.Swap("Baz", "NewBaz");
            var example2 = new List<string>(stringList);
            example2.Swap("NoValueFound", "NoBaz");
            var example3 = new List<string>(stringList);
            example3.Swap(null, "NothingChanged");
            var example4 = new List<string>(stringList);
            example4.Swap("Bar", "NewBar");

            // Expected results
            var result1 = new List<string>() {"Foo", "Bar", "NewBaz"};
            var result2 = new List<string>(stringList);
            var result3 = new List<string>(stringList);
            var result4 = example4.ElementAt(1).Equals("NewBar");

            // Unit Test
            Assert.IsTrue(example1.Contains("NewBaz"), "The collection should contain this value");
            Assert.IsFalse(example2.Contains("NoBaz"), "The collection shouldn't contain this value");
            Assert.IsTrue(example1.SequenceEqual(result1), "The collection should have the replaced value");
            Assert.IsTrue(example2.SequenceEqual(result2), "The collection shouldn't have the replaced value");
            Assert.IsTrue(example3.SequenceEqual(result3), "The collection shouldn't have the replaced value");
            Assert.IsTrue(result4, "The item in a collection shouldn't change it's position");
        }
    }
}