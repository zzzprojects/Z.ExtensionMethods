// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_AsOrDefault
    {
        [TestMethod]
        public void AsOrDefault()
        {
            // Type
            object intValue = 1;
            object invalidValue = "Fizz";

            // Exemples
            var result1 = intValue.AsOrDefault<int>(); // return 1;
            var result2 = invalidValue.AsOrDefault<int>(); // return 0;
            int result3 = invalidValue.AsOrDefault(3); // return 3;
            int result4 = invalidValue.AsOrDefault(() => 4); // return 4;

            // Unit Test
            Assert.AreEqual(1, result1);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(3, result3);
            Assert.AreEqual(4, result4);
        }
    }
}