using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_IDataReader_ToDataTable
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
                        DataTable result = reader.ToDataTable();

                        // Unit Test
                        Assert.AreEqual(1, result.Rows[0][0]);
                        Assert.AreEqual("FizzBuzz", result.Rows[0][1]);
                    }
                }
            }
        }
    }
}