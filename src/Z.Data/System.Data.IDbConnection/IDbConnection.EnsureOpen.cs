using System.Data;

public static partial class Extensions
{
    /// <summary>
    ///     An IDbConnection extension method that ensures that open.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void EnsureOpen(this IDbConnection @this)
    {
        if (@this.State == ConnectionState.Closed)
        {
            @this.Open();
        }
    }
}