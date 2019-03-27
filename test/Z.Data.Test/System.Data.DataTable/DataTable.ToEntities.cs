// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_DataTable_ToEntities
    {
        [TestMethod]
        public void ToEntities()
        {
            // Type
            var @this = new DataTable();

            // Variables
            @this.Columns.AddRange("IntColumn", "StringColumn");
            @this.Rows.Add(1, "Fizz");
            @this.Rows.Add(2, "Buzz");

            // Exemples
            List<TestObject> entities = @this.ToEntities<TestObject>().ToList();

            // Unit Test
            Assert.AreEqual(2, entities.Count);
            Assert.AreEqual(1, entities[0].IntColumn);
            Assert.AreEqual("Fizz", entities[0].StringColumn);
            Assert.AreEqual(2, entities[1].IntColumn);
            Assert.AreEqual("Buzz", entities[1].StringColumn);
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