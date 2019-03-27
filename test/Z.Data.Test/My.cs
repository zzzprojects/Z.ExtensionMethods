// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Configuration;

namespace Z.Data.Test
{
    public static class My
    {
        public static class Config
        {
            public static class ConnectionString
            {
                public static ConnectionStringSettings UnitTest = ConfigurationManager.ConnectionStrings["UnitTest"];
            }
        }
    }
}