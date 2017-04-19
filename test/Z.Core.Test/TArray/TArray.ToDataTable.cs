// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class TArray_ToDataTable
    {
        [TestMethod]
        public void ToDataTable()
        {
            // Type
            var @this = new[]
            {
                new TestObject
                {
                    IntColumn = 1,
                    StringColumn = "2"
                },
                new TestObject
                {
                    IntColumn = 3,
                    StringColumn = "4"
                }
            };

            // Exemples
            DataTable dt = @this.ToDataTable(); // Transorm entities to DataTable

            // Unit Test
            Assert.AreEqual(2, dt.Rows.Count);
            Assert.AreEqual(1, dt.Rows[0]["IntColumn"]);
            Assert.AreEqual("2", dt.Rows[0]["StringColumn"]);
            Assert.AreEqual(3, dt.Rows[1]["IntColumn"]);
            Assert.AreEqual("4", dt.Rows[1]["StringColumn"]);
        }

        public class TestObject
        {
            public int IntColumn;
            public string StringColumn { get; set; }
        }
    }
}