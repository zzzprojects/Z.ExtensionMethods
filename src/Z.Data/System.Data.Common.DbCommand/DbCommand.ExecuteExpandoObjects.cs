using System.Collections.Generic;
using System.Data;
using System.Data.Common;

public static partial class Extensions
{
    /// <summary>
    ///     Enumerates execute expando objects in this collection.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>
    ///     An enumerator that allows foreach to be used to process execute expando objects in this collection.
    /// </returns>
    public static IEnumerable<dynamic> ExecuteExpandoObjects(this DbCommand @this)
    {
        using (IDataReader reader = @this.ExecuteReader())
        {
            return reader.ToExpandoObjects();
        }
    }
}