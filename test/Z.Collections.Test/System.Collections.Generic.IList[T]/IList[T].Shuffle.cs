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
    public class System_Collections_Generic_IList_T_Shuffle
    {
        [TestMethod]
        public void Shuffle()
        {
            // Input
            var intList = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };

            // Examples
            var example1 = new List<int>(intList);
            var example2 = new List<int>(intList);
            var example3 = new List<int>(intList);
            var example4 = new List<int>(intList);
            var example5 = new List<int>(intList);

            //Shuffle and pack results
            example1.Shuffle();
            example2.Shuffle();
            example3.Shuffle();
            example4.Shuffle();
            example5.Shuffle();

            var shuffledResults = new List<List<int>> {example1, example2, example3, example4, example5}; 

            // Unit Test
            Assert.IsTrue(shuffledResults.All(e=> e.Count() == 20), "The shuffle should't change the collection length");
            Assert.IsFalse(shuffledResults.Contains(intList), "The input collection should not be contained in shuffled results");
            Assert.IsTrue(shuffledResults.Distinct().Count() == shuffledResults.Count, "The shuffled results should be unique");
        }
    }
}