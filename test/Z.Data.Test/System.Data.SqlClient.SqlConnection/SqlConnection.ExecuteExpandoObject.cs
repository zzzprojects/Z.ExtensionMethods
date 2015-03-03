using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_SqlClient_SqlConnection_ExecuteExpandoObject
    {
        [TestMethod]
        public void ExecuteExpandoObject()
        {
            string sql = "SELECT 1 AS IntColumn, 'FizzBuzz' AS StringColumn WHERE @Fizz = 1";
            var dict = new Dictionary<string, object> {{"@Fizz", 1}};

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                conn.Open();
                dynamic entity = conn.ExecuteExpandoObject(sql, dict.ToSqlParameters());

                // Unit Test
                Assert.AreEqual(1, entity.IntColumn);
                Assert.AreEqual("FizzBuzz", entity.StringColumn);
            }
        }
    }
}