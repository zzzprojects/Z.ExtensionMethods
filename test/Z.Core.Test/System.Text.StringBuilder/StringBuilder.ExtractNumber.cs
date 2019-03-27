// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_ExtractNumber
    {
        [TestMethod]
        public void ExtractNumber()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractNumber());
            Assert.AreEqual(null, new StringBuilder(".").ExtractNumber());
            Assert.AreEqual("1", new StringBuilder("1").ExtractNumber().ToString());
            Assert.AreEqual(".1", new StringBuilder(".1").ExtractNumber().ToString());
            Assert.AreEqual(".1", new StringBuilder(".1.1").ExtractNumber().ToString());
            Assert.AreEqual(".1D", new StringBuilder(".1D").ExtractNumber().ToString());
            Assert.AreEqual(".1", new StringBuilder("1.1").ExtractNumber(1).ToString());
            Assert.AreEqual(".1F", new StringBuilder("1.1F1").ExtractNumber(1, out endIndex).ToString());
            Assert.AreEqual(3, endIndex);
        }
    }
}