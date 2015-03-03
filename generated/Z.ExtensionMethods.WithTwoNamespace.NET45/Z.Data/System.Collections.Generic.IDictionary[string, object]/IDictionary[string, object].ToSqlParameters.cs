using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

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

}