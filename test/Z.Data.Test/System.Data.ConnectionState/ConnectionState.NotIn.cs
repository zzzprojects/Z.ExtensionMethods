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
    public class System_Data_ConnectionState_NotIn
    {
        [TestMethod]
        public void NotIn()
        {
            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                bool result1 = conn.State.NotIn(ConnectionState.Closed, ConnectionState.Open); // return false;
                bool result2 = conn.State.NotIn(ConnectionState.Open, ConnectionState.Executing); // return true;

                Assert.IsFalse(result1);
                Assert.IsTrue(result2);
            }
        }
    }
}