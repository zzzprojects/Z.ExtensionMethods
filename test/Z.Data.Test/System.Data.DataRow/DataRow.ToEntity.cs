// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_DataRow_ToEntity
    {
        [TestMethod]
        public void ToEntity()
        {
            // Type
            var @this = new DataTable();

            // Variables
            @this.Columns.AddRange("IntColumn", "StringColumn");
            @this.Rows.Add(1, "Fizz");

            // Exemples
            var entity = @this.Rows[0].ToEntity<TestObject>();

            // Unit Test
            Assert.AreEqual(1, entity.IntColumn);
            Assert.AreEqual("Fizz", entity.StringColumn);
        }

        public class TestObject
        {
            public int IntColumn;
            public int IntColumnNotExists = -1;
            public string StringColumnNotExists;
            public string StringColumn { get; set; }
        }
    }
}