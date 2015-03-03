namespace Z.ExtensionMethods
{

using System.Collections.Generic;
using System.Data;
using System.Data.Common;

public static partial class Extensions
{
    /// <summary>
    ///     Enumerates execute entities in this collection.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>An enumerator that allows foreach to be used to process execute entities in this collection.</returns>
    public static IEnumerable<T> ExecuteEntities<T>(this DbCommand @this) where T : new()
    {
        using (IDataReader reader = @this.ExecuteReader())
        {
            return reader.ToEntities<T>();
        }
    }
}

}