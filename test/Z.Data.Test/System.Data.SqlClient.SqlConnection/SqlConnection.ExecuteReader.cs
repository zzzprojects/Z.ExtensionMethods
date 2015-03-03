using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_SqlClient_SqlConnection_ExecuteReader
    {
        [TestMethod]
        public void ExecuteReader()
        {
            string sql = "SELECT 1 AS IntColumn, 'FizzBuzz' AS StringColumn WHERE @Fizz = 1";
            var dict = new Dictionary<string, object> {{"@Fizz", 1}};

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                conn.Open();
                using (IDataReader reader = conn.ExecuteReader(sql, dict.ToSqlParameters()))
                {
                    reader.Read();
                    object result1 = reader[0];
                    object result2 = reader[1];

                    // Unit Test
                    Assert.AreEqual(1, result1);
                    Assert.AreEqual("FizzBuzz", result2);
                }
            }
        }
    }
}