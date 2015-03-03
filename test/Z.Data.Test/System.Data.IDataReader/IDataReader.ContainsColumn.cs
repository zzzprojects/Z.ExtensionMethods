using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_IDataReader_ContainsColumn
    {
        [TestMethod]
        public void ContainsColumn()
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

                        bool result1 = reader.ContainsColumn("IntColumn"); // return true;
                        bool result2 = reader.ContainsColumn("ABC"); // return false;

                        // Unit Test
                        Assert.IsTrue(result1);
                        Assert.IsFalse(result2);
                    }
                }
            }
        }
    }
}