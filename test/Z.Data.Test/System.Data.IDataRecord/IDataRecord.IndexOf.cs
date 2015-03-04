// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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