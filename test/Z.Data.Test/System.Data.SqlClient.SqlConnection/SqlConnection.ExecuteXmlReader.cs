// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_SqlClient_SqlConnection_ExecuteXmlReader
    {
        [TestMethod]
        public void ExecuteReader()
        {
            string sql = "SELECT '1' AS A WHERE @Fizz = 1 FOR XML RAW";
            var dict = new Dictionary<string, object> {{"@Fizz", 1}};

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                conn.Open();
                using (XmlReader reader = conn.ExecuteXmlReader(sql, dict.ToSqlParameters()))
                {
                    reader.Read();

                    object result1 = reader[0];

                    // Unit Test
                    Assert.AreEqual("1", result1);
                }
            }
        }
    }
}