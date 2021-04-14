// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test {
    [TestClass]
    public class System_String_RemovStrings {
        [TestMethod]
        public void RemoveStrings() {
            // Type
            string @this = "Fizz  Buzz ";
            string this2 = "Fizz  Buzz   ";

            // Examples
            string result = @this.RemoveStrings(false, "Buz", "Fiz"); // return "z  z ";
            string result2 = this2.RemoveStrings(true, "Buz", "Fiz"); // return "zz";

            // Unit Test
            Assert.AreEqual("z  z ", result);
            Assert.AreEqual("zz", result2);
        }
    }
}