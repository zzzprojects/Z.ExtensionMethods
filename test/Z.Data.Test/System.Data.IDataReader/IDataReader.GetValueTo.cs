using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_IDataReader_GetValueTo
    {
        [TestMethod]
        public void GetValueTo()
        {
            const string sql = @"SELECT 1 As IntColumn";

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                using (SqlCommand @this = conn.CreateCommand())
                {
                    conn.Open();
                    @this.CommandText = sql;
                    using (SqlDataReader reader = @this.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var result = reader.GetValueTo<int>("IntColumn");

                            // UnitTest
                            Assert.AreEqual(1, result);
                        }
                    }
                }
            }
        }
    }
}