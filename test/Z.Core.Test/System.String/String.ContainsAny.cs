// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ContainsAny
    {
        [TestMethod]
        public void ContainsAny()
        {
            // Type
            string @this = "Fizz";

            // Examples
            bool value1 = @this.ContainsAny("F", "Buzz"); // value = ";
            bool value2 = @this.ContainsAny("Bizz", "Buzz"); // value = ";
            bool value3 = @this.ContainsAny(StringComparison.InvariantCultureIgnoreCase, "f", "Buzz"); // value = ";
            bool value4 = @this.ContainsAny(StringComparison.InvariantCulture, "f", "Buzz"); // value = ";

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
            Assert.IsTrue(value3);
            Assert.IsFalse(value4);
        }
    }
}