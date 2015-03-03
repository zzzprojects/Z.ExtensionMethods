using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_IDataReader_ForEach
    {
        [TestMethod]
        public void ToEntity()
        {
            string sql = "SELECT 'Fizz' UNION SELECT 'Buzz'";
            string result = "";

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                conn.Open();
                using (DbCommand command = conn.CreateCommand())
                {
                    command.CommandText = sql;
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        reader.ForEach(dataReader => result += dataReader[0]);
                    }
                }
            }

            // Unit Test
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}