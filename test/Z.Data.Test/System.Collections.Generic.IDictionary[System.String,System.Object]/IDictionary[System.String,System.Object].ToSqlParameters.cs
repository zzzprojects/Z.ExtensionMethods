// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Collections_Generic_IDictionary_System_String_System_Object_ToSqlParameters
    {
        [TestMethod]
        public void ToSqlParameters()
        {
            const string sql = @"SELECT 1 WHERE @Fizz = 1 AND @Buzz = 2";
            var dict = new Dictionary<string, object>();
            dict.Add("@Fizz", 1);
            dict.Add("@Buzz", 2);

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                using (SqlCommand command = conn.CreateCommand())
                {
                    command.CommandText = sql;
                    command.Parameters.AddRange(dict.ToSqlParameters());
                    conn.Open();

                    object result = command.ExecuteScalar();

                    // UnitTest
                    Assert.AreEqual(1, result);
                }
            }
        }
    }
}