// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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