// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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