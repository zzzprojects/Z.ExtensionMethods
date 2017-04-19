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
    public class System_Object_Coalesce
    {
        [TestMethod]
        public void Coalesce()
        {
            // Type
            object @thisNull = null;
            object @thisNotNull = "Fizz";

            // Exemples
            object result1 = @thisNull.Coalesce(null, null, "Fizz", "Buzz"); // return "Fizz";
            object result2 = @thisNull.Coalesce(null, "Fizz", null, "Buzz"); // return "Fizz";
            object result3 = @thisNotNull.Coalesce(null, null, null, "Buzz"); // return "Fizz";

            // Unit Test
            Assert.AreEqual("Fizz", result1);
            Assert.AreEqual("Fizz", result2);
            Assert.AreEqual("Fizz", result3);
        }
    }
}