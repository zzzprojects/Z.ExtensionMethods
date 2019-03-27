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