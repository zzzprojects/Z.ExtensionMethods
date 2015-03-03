using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_ConnectionState_NotIn
    {
        [TestMethod]
        public void NotIn()
        {
            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                bool result1 = conn.State.NotIn(ConnectionState.Closed, ConnectionState.Open); // return false;
                bool result2 = conn.State.NotIn(ConnectionState.Open, ConnectionState.Executing); // return true;

                Assert.IsFalse(result1);
                Assert.IsTrue(result2);
            }
        }
    }
}