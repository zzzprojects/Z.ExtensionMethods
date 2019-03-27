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