using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_Common_IDbConnection
    {
        [TestMethod]
        public void EnsureOpen()
        {
            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                ConnectionState result1 = conn.State;
                conn.EnsureOpen();
                ConnectionState result2 = conn.State;
                conn.EnsureOpen();
                ConnectionState result3 = conn.State;

                // Unit Test
                Assert.AreEqual(ConnectionState.Closed, result1);
                Assert.AreEqual(ConnectionState.Open, result2);
                Assert.AreEqual(ConnectionState.Open, result3);
            }
        }
    }
}