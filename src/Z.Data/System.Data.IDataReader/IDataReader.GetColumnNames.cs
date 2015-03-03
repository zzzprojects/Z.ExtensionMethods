using System.Collections.Generic;
using System.Data;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     Gets the column names in this collection.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>An enumerator that allows foreach to be used to get the column names in this collection.</returns>
    public static IEnumerable<string> GetColumnNames(this IDataRecord @this)
    {
        return Enumerable.Range(0, @this.FieldCount)
            .Select(@this.GetName)
            .ToList();
    }
}