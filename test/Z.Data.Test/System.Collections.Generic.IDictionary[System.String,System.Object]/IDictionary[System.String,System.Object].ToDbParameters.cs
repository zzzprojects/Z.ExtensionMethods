using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Collections_Generic_IDictionary_System_String_System_Object_ToDbParameters
    {
        [TestMethod]
        public void ToDbParameters()
        {
            const string sql = @"SELECT 1 WHERE @Fizz = 1 AND @Buzz = 2";
            var dict = new Dictionary<string, object>();
            dict.Add("@Fizz", 1);
            dict.Add("@Buzz", 2);

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                using (DbCommand command = conn.CreateCommand())
                {
                    command.CommandText = sql;
                    command.Parameters.AddRange(dict.ToDbParameters(command));
                    conn.Open();

                    object result = command.ExecuteScalar();

                    // UnitTest
                    Assert.AreEqual(1, result);
                }
            }

            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                using (SqlCommand command = conn.CreateCommand())
                {
                    command.CommandText = sql;
                    command.Parameters.AddRange(dict.ToDbParameters(conn));
                    conn.Open();

                    object result = command.ExecuteScalar();

                    // UnitTest
                    Assert.AreEqual(1, result);
                }
            }
        }
    }
}