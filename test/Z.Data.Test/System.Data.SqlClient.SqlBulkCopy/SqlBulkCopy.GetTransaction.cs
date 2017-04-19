// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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