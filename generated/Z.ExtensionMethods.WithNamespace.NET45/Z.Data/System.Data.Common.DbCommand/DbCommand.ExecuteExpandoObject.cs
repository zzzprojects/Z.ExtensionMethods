using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.DataExtensions
{

using System.Data;
using System.Data.Common;

public static partial class Extensions
{
    /// <summary>
    ///     A DbCommand extension method that executes the expando object operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A dynamic.</returns>
    public static dynamic ExecuteExpandoObject(this DbCommand @this)
    {
        using (IDataReader reader = @this.ExecuteReader())
        {
            reader.Read();
            return reader.ToExpandoObject();
        }
    }
}

}