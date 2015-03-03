using System.Data.Common;

public static partial class Extensions
{
    /// <summary>
    ///     A DbCommand extension method that executes the scalar as operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A T.</returns>
    public static T ExecuteScalarAs<T>(this DbCommand @this)
    {
        return (T) @this.ExecuteScalar();
    }
}