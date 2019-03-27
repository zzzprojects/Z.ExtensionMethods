// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Boolean_IfTrue
    {
        [TestMethod]
        public void IfTrue()
        {
            // Variables
            string value1 = "";
            string value2 = "";

            // Type
            const bool conditionTrue = true;
            const bool conditionFalse = false;

            // Examples
            conditionTrue.IfTrue(() => value1 = "FizzBuzz"); // value1 = "FizzBuzz";
            conditionFalse.IfTrue(() => value2 = "FizzBuzz"); // value2 = "";

            // Unit Test
            Assert.AreEqual("FizzBuzz", value1);
            Assert.AreEqual("", value2);
        }
    }
}