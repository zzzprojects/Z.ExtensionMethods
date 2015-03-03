using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_IDataRecord_IndexOf
    {
        [TestMethod]
        public void IndexOf()
        {
            const string sql = @"
SELECT 1 AS A
";
            //// Examples
            //using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            //{
            //    using (SqlCommand @this = conn.CreateCommand())
            //    {
            //        conn.Open();
            //        @this.CommandText = sql;
            //        using (SqlDataReader reader = @this.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                int result = reader.IndexOf("A"); // return 0;

            //                // UnitTest
            //                Assert.AreEqual(0, result);
            //            }
            //        }
            //    }
            //}
        }
    }
}