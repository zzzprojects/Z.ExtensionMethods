// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_Common_IDbConnection
    {
        [TestMethod]
        public void EnsureOpen()
        {
            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                ConnectionState result1 = conn.State;
                conn.EnsureOpen();
                ConnectionState result2 = conn.State;
                conn.EnsureOpen();
                ConnectionState result3 = conn.State;

                // Unit Test
                Assert.AreEqual(ConnectionState.Closed, result1);
                Assert.AreEqual(ConnectionState.Open, result2);
                Assert.AreEqual(ConnectionState.Open, result3);
            }
        }
    }
}