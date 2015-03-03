using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_SqlClient_SqlConnection_ExecuteScalar
    {
        [TestMethod]
        public void ExecuteScalar()
        {
            const string sql = @"SELECT 1 As IntColumn WHERE @Fizz = 1";
            var dict = new Dictionary<string, object> {{"@Fizz", 1}};

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                conn.Open();
                object result = conn.ExecuteScalar(sql, dict.ToSqlParameters());

                // UnitTest
                Assert.AreEqual(1, result);
            }
        }
    }
}