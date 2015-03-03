using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_IDataReader_ToExpandoObject
    {
        [TestMethod]
        public void ToExpandoObject()
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
                        dynamic entity = reader.ToExpandoObject();

                        // Unit Test
                        Assert.AreEqual(1, entity.IntColumn);
                        Assert.AreEqual("FizzBuzz", entity.StringColumn);
                    }
                }
            }
        }
    }
}