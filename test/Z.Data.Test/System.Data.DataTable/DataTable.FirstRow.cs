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
    public class System_Data_DataTable_FirstRow
    {
        [TestMethod]
        public void FirstRow()
        {
            // Type
            var @this = new DataTable();

            // Variables
            @this.Columns.Add("UnitTest");
            @this.Rows.Add("Fizz");
            @this.Rows.Add("Buzz");

            // Exemples
            DataRow result = @this.FirstRow(); // return @this.Rows[0];

            // Unit Test
            Assert.AreEqual("Fizz", result["UnitTest"]);
        }
    }
}