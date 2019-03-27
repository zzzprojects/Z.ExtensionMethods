// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_SqlClient_SqlCommand_ExecuteDataTable
    {
        [TestMethod]
        public void ExecuteDataTable()
        {
            DataTable result;
            const string sql = @"
SELECT  1 AS A
UNION
SELECT  2
UNION
SELECT  3
";

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                using (SqlCommand @this = conn.CreateCommand())
                {
                    conn.Open();
                    @this.CommandText = sql;
                    result = @this.ExecuteDataTable(); // return DataTable (3 rows).
                }
            }

            // Unit Test
            Assert.AreEqual(3, result.Rows.Count);
        }
    }
}