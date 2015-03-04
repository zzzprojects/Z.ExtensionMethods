// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_DataColumnCollection_AddRange
    {
        [TestMethod]
        public void AddRange()
        {
            // Type
            var @this = new DataTable();

            // Exemples
            @this.Columns.AddRange("Column1", "Column2", "Column3"); // Add "Column1", "Column2", "Column3" to the collection

            // Unit Test
            Assert.AreEqual(3, @this.Columns.Count);
        }
    }
}