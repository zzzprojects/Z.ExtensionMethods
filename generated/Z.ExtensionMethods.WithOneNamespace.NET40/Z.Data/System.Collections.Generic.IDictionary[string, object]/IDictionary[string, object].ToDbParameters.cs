namespace Z.ExtensionMethods
{

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

}