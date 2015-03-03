using System.Data;
using System.Data.Common;

public static partial class Extensions
{
    /// <summary>A DbConnection extension method that queries if a connection is open.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if a connection is open, false if not.</returns>
    public static bool IsConnectionOpen(this DbConnection @this)
    {
        return @this.State == ConnectionState.Open;
    }
}