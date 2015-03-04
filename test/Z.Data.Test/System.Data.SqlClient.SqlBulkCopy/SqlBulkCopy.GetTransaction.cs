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
    public class System_Data_SqlClient_SqlBulkCopy_GetTransaction
    {
        [TestMethod]
        public void GetTransaction()
        {
            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                using (var @this = new SqlBulkCopy(conn, SqlBulkCopyOptions.Default, trans))
                {
                    SqlTransaction result = @this.GetTransaction();

                    // Unit Test
                    Assert.AreEqual(trans, result);
                }
            }
        }
    }
}