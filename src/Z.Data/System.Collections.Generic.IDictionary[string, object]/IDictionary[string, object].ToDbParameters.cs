// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     An IDictionary&lt;string,object&gt; extension method that converts this object to a database parameters.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="command">The command.</param>
    /// <returns>The given data converted to a DbParameter[].</returns>
    public static DbParameter[] ToDbParameters(this IDictionary<string, object> @this, DbCommand command)
    {
        return @this.Select(x =>
        {
            DbParameter parameter = command.CreateParameter();
            parameter.ParameterName = x.Key;
            parameter.Value = x.Value;
            return parameter;
        }).ToArray();
    }

    /// <summary>
    ///     An IDictionary&lt;string,object&gt; extension method that converts this object to a database parameters.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="connection">The connection.</param>
    /// <returns>The given data converted to a DbParameter[].</returns>
    public static DbParameter[] ToDbParameters(this IDictionary<string, object> @this, DbConnection connection)
    {
        DbCommand command = connection.CreateCommand();

        return @this.Select(x =>
        {
            DbParameter parameter = command.CreateParameter();
            parameter.ParameterName = x.Key;
            parameter.Value = x.Value;
            return parameter;
        }).ToArray();
    }
}