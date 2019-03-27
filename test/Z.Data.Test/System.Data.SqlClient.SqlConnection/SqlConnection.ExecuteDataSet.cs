// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_SqlClient_SqlConnection_ExecuteDataSet
    {
        [TestMethod]
        public void ExecuteDataSet()
        {
            DataSet result;
            const string sql = @"
SELECT 1
SELECT 2
SELECT 3 WHERE @Fizz = 1
";
            var dict = new Dictionary<string, object> {{"@Fizz", 1}};

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                conn.Open();
                result = conn.ExecuteDataSet(sql, dict.ToSqlParameters()); // return DataSet (3 tables).
            }

            // Unit Test
            Assert.AreEqual(3, result.Tables.Count);
        }
    }
}