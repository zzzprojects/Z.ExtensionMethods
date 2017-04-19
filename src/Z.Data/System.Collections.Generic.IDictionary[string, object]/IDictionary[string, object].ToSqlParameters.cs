// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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