// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     An IDictionary&lt;string,object&gt; extension method that converts the @this to a SQL parameters.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a SqlParameter[].</returns>
    public static SqlParameter[] ToSqlParameters(this IDictionary<string, object> @this)
    {
        return @this.Select(x => new SqlParameter(x.Key, x.Value)).ToArray();
    }
}