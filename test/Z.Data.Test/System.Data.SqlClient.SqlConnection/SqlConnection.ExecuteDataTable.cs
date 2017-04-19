// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_SqlClient_SqlConnection_ExecuteDataTable
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
SELECT  3 WHERE @Fizz = 1
";
            var dict = new Dictionary<string, object> {{"@Fizz", 1}};

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                conn.Open();
                result = conn.ExecuteDataTable(sql, dict.ToSqlParameters()); // return DataTable (3 rows).
            }

            // Unit Test
            Assert.AreEqual(3, result.Rows.Count);
        }
    }
}