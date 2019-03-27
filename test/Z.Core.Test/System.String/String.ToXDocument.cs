// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ToXDocument
    {
        [TestMethod]
        public void ToXDocument()
        {
            // Type
            string @this = "<Fizz>Buzz</Fizz>";

            // Examples
            XDocument value = @this.ToXDocument(); // return a XDocument from the specified string.

            // Unit Test
            Assert.AreEqual("<Fizz>Buzz</Fizz>", value.ToString());
        }
    }
}