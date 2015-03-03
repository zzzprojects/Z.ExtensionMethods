using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_SqlClient_SqlCommand_ExecuteDataSet
    {
        [TestMethod]
        public void ExecuteDataSet()
        {
            DataSet result;
            const string sql = @"
SELECT 1
SELECT 2
SELECT 3
";

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                using (SqlCommand @this = conn.CreateCommand())
                {
                    conn.Open();
                    @this.CommandText = sql;
                    result = @this.ExecuteDataSet(); // return DataSet (3 tables).
                }
            }

            // Unit Test
            Assert.AreEqual(3, result.Tables.Count);
        }
    }
}