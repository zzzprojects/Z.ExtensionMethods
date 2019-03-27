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
    public class System_Data_IDataReader_IsDBNull
    {
        [TestMethod]
        public void IsDBNull()
        {
            const string sql = @"
SELECT 1, NULL
";

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                using (SqlCommand @this = conn.CreateCommand())
                {
                    conn.Open();
                    @this.CommandText = sql;
                    using (SqlDataReader reader = @this.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bool result1 = reader.IsDBNull(0); // return false;
                            bool result2 = reader.IsDBNull(1); // return true;

                            // UnitTest
                            Assert.IsFalse(result1);
                            Assert.IsTrue(result2);
                        }
                    }
                }
            }
        }
    }
}