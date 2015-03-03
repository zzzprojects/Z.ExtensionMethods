using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_SqlClient_SqlBulkCopy_GetConnection
    {
        [TestMethod]
        public void GetConnection()
        {
            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                using (var @this = new SqlBulkCopy(conn))
                {
                    SqlConnection result = @this.GetConnection();

                    // Unit Test
                    Assert.AreEqual(conn, result);
                }
            }
        }
    }
}