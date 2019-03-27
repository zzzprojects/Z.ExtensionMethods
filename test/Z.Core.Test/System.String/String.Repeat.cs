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
    public class System_String_Repeat
    {
        [TestMethod]
        public void Repeat()
        {
            // Type
            string @this = "Fizz";

            // Examples
            string value = @this.Repeat(3); // return "FizzFizzFizz";

            // Unit Test
            Assert.AreEqual("FizzFizzFizz", value);
        }
    }
}