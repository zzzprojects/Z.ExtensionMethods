using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System.Data;

public static partial class Extensions
{
    /// <summary>
    ///     An IDataReader extension method that gets value to.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="index">Zero-based index of the.</param>
    /// <returns>The value to.</returns>
    public static T GetValueTo<T>(this IDataReader @this, int index)
    {
        return @this.GetValue(index).To<T>();
    }

    /// <summary>
    ///     An IDataReader extension method that gets value to.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="columnName">Name of the column.</param>
    /// <returns>The value to.</returns>
    public static T GetValueTo<T>(this IDataReader @this, string columnName)
    {
        return @this.GetValue(@this.GetOrdinal(columnName)).To<T>();
    }
}

}