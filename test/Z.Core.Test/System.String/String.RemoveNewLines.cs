// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test {
    [TestClass]
    public class System_String_RemoveNewLines {
        [TestMethod]
        public void RemoveNewLines() {
            // Type
            string @this = @"Fizz
                             Buzz ";

            string @this2 = @"Fizz
                            Buzz ";

            // Examples
            string result = @this.RemoveNewLines(); // return "Fizz                             Buzz ";
            string result2 = @this2.RemoveNewLines(true); // return "FizzBuzz";

            // Unit Test
            Assert.AreEqual("Fizz                             Buzz ", result);
            Assert.AreEqual("FizzBuzz", result2);
        }
    }
}