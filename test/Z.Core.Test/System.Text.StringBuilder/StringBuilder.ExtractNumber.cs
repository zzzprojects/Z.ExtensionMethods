// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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