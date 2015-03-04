// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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