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
            var stringList = new List<string>() { "Foo", "Bar", "Baz" };
            var obj1 = new { Id = 1, Message = "Foo" };
            var obj2 = new { Id= 2, Message = "Bar" };
            var obj3 = new { Id = 3, Message = "Baz" };

            // Examples
            var example1 = new List<string>(stringList);
            var example2 = new List<string>(stringList);
            var example3 = new List<string>(stringList);
            var example4 = new List<string>(stringList);
            var example5 = new List<string>() {"Foo", "Bar", "Bar"};
            var example6 = new List<object>() { obj1, obj2 };

            //Swaps
            example1.Swap("Baz", "NewBaz");
            example2.Swap("NoValueFound", "NoBaz");
            example3.Swap(null, "NothingChanged");
            example4.Swap("Bar", "NewBar");
            example5.Swap("Bar", "Baz");
            example6.Swap(obj2, obj3);

            // Expected results
            var result1 = new List<string>() {"Foo", "Bar", "NewBaz"};
            var result2 = new List<string>(stringList);
            var result3 = new List<string>(stringList);
            var result4 = example4.ElementAt(1).Equals("NewBar");
            var result5 = example5.Contains("Bar");
            var result6 = example6.Contains(obj3);

            // Unit Test
            Assert.IsTrue(example1.Contains("NewBaz"), "The collection should contain this value");
            Assert.IsFalse(example2.Contains("NoBaz"), "The collection shouldn't contain this value");
            Assert.IsTrue(example1.SequenceEqual(result1), "The collection should have the replaced value");
            Assert.IsTrue(example2.SequenceEqual(result2), "The collection shouldn't have the replaced value");
            Assert.IsTrue(example3.SequenceEqual(result3), "The collection shouldn't have the replaced value");
            Assert.IsTrue(result4, "The item in a collection shouldn't change it's position");
            Assert.IsFalse(result5, "All values should be swaped");
            Assert.IsTrue(result6, "The object in a collection should be swaped");
        }
    }
}