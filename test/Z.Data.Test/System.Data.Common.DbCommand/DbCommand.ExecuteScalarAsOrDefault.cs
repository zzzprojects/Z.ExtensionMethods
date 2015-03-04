// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_Common_DbCommand_ExecuteScalarAsOrDefault
    {
        [TestMethod]
        public void ExecuteScalarAsOrDefault()
        {
            const string sql = @"SELECT 'FizzBuzz' As StringColumn";

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                using (SqlCommand @this = conn.CreateCommand())
                {
                    conn.Open();
                    @this.CommandText = sql;
                    var result1 = @this.ExecuteScalarAsOrDefault<string>();
                    var result2 = @this.ExecuteScalarAsOrDefault<int>();
                    int result3 = @this.ExecuteScalarAsOrDefault(-1);
                    int result4 = @this.ExecuteScalarAsOrDefault(command => -2);

                    // UnitTest
                    Assert.AreEqual("FizzBuzz", result1);
                    Assert.AreEqual(0, result2);
                    Assert.AreEqual(-1, result3);
                    Assert.AreEqual(-2, result4);
                }
            }
        }
    }
}