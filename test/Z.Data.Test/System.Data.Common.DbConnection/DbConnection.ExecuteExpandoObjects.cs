// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_Common_DbConnection_ExecuteExpandoObjects
    {
        [TestMethod]
        public void ExecuteExpandoObjects()
        {
            string sql = "SELECT 1 AS IntColumn, 'FizzBuzz' AS StringColumn UNION SELECT 2, 'BuzzBuzz' WHERE @Fizz = 1";
            var dict = new Dictionary<string, object> {{"@Fizz", 1}};

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                conn.Open();
                List<dynamic> list = conn.ExecuteExpandoObjects(sql, dict.ToDbParameters(conn)).ToList();

                // Unit Test
                Assert.AreEqual(1, list[0].IntColumn);
                Assert.AreEqual("FizzBuzz", list[0].StringColumn);
                Assert.AreEqual(2, list[1].IntColumn);
                Assert.AreEqual("BuzzBuzz", list[1].StringColumn);
            }
        }
    }
}