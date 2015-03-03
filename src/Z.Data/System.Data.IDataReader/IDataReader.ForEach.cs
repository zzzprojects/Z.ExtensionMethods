using System;
using System.Data;

public static partial class Extensions
{
    /// <summary>
    ///     An IDataReader extension method that applies an operation to all items in this collection.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="action">The action.</param>
    /// <returns>An IDataReader.</returns>
    public static IDataReader ForEach(this IDataReader @this, Action<IDataReader> action)
    {
        while (@this.Read())
        {
            action(@this);
        }

        return @this;
    }
}