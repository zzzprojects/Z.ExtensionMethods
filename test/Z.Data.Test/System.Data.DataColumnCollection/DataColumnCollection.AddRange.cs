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