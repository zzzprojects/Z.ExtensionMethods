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