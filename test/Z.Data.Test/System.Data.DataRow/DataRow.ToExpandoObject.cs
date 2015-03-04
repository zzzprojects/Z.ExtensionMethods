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
    public class System_Data_DataRow_ToExpandoObject
    {
        [TestMethod]
        public void ToExpandoObject()
        {
            // Type
            var @this = new DataTable();

            // Variables
            @this.Columns.Add("IntColumn", typeof (int));
            @this.Columns.Add("StringColumn", typeof (string));
            @this.Rows.Add(1, "Fizz");

            // Exemples
            dynamic expandoObject = @this.Rows[0].ToExpandoObject();

            // Unit Test
            Assert.AreEqual(1, expandoObject.IntColumn);
            Assert.AreEqual("Fizz", expandoObject.StringColumn);
        }
    }
}