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
    public class System_Data_ConnectionState_In
    {
        [TestMethod]
        public void In()
        {
            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                bool result1 = conn.State.In(ConnectionState.Closed, ConnectionState.Open); // return true;
                bool result2 = conn.State.In(ConnectionState.Open, ConnectionState.Executing); // return false;

                Assert.IsTrue(result1);
                Assert.IsFalse(result2);
            }
        }
    }
}