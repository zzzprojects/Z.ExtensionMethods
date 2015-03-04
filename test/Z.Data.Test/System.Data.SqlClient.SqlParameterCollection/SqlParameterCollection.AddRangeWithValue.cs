// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_SqlClient_SqlParameterCollection_AddRangeWithValue
    {
        [TestMethod]
        public void AddRangeWithValue()
        {
            const string sql = @"SELECT 1 As IntColumn WHERE @Value1 = 1 AND @Value2 = 2";

            var dict = new Dictionary<string, object> {{"@Value1", 1}, {"@Value2", 2}};

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                using (SqlCommand @this = conn.CreateCommand())
                {
                    conn.Open();
                    @this.CommandText = sql;
                    @this.Parameters.AddRangeWithValue(dict);
                    var result = @this.ExecuteScalarAs<int>();

                    // UnitTest
                    Assert.AreEqual(1, result);
                }
            }
        }
    }
}