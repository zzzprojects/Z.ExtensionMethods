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