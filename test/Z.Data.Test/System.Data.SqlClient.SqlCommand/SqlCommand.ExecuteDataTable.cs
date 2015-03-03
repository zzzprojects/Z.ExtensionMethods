using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_SqlClient_SqlCommand_ExecuteDataTable
    {
        [TestMethod]
        public void ExecuteDataTable()
        {
            DataTable result;
            const string sql = @"
SELECT  1 AS A
UNION
SELECT  2
UNION
SELECT  3
";

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                using (SqlCommand @this = conn.CreateCommand())
                {
                    conn.Open();
                    @this.CommandText = sql;
                    result = @this.ExecuteDataTable(); // return DataTable (3 rows).
                }
            }

            // Unit Test
            Assert.AreEqual(3, result.Rows.Count);
        }
    }
}