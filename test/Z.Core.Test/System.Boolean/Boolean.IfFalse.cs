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
    public class System_Boolean_IfFalse
    {
        [TestMethod]
        public void IfFalse()
        {
            // Variables
            string value1 = "";
            string value2 = "";

            // Type
            const bool conditionTrue = true;
            const bool conditionFalse = false;

            // Examples
            conditionTrue.IfFalse(() => value1 = "FizzBuzz"); // value1 = "";
            conditionFalse.IfFalse(() => value2 = "FizzBuzz"); // value2 = "FizzBuzz";

            // Unit Test
            Assert.AreEqual("", value1);
            Assert.AreEqual("FizzBuzz", value2);
        }
    }
}