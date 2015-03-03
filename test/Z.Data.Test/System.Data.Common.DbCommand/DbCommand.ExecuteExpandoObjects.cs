using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_Common_DbCommand_ExecuteExpandoObjects
    {
        [TestMethod]
        public void ExecuteExpandoObjects()
        {
            string sql = "SELECT 1 AS IntColumn, 'FizzBuzz' AS StringColumn UNION SELECT 2, 'BuzzBuzz'";

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                conn.Open();
                using (DbCommand command = conn.CreateCommand())
                {
                    command.CommandText = sql;
                    List<dynamic> list = command.ExecuteExpandoObjects().ToList();

                    // Unit Test
                    Assert.AreEqual(1, list[0].IntColumn);
                    Assert.AreEqual("FizzBuzz", list[0].StringColumn);
                    Assert.AreEqual(2, list[1].IntColumn);
                    Assert.AreEqual("BuzzBuzz", list[1].StringColumn);
                }
            }
        }
    }
}