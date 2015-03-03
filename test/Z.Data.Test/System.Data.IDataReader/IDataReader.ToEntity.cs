using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_IDataReader_ToEntity
    {
        [TestMethod]
        public void ToEntity()
        {
            string sql = "SELECT 1 AS IntColumn, 'FizzBuzz' AS StringColumn";
            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                conn.Open();
                using (DbCommand command = conn.CreateCommand())
                {
                    command.CommandText = sql;
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        var entity = reader.ToEntity<TestObject>();

                        // Unit Test
                        Assert.AreEqual(1, entity.IntColumn);
                        Assert.AreEqual("FizzBuzz", entity.StringColumn);
                        Assert.AreEqual(-1, entity.IntColumnNotExists);
                    }
                }
            }
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