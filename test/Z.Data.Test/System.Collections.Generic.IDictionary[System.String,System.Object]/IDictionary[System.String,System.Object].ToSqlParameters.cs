// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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