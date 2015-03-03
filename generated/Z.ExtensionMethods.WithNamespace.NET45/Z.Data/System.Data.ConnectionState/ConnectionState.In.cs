using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.DataExtensions
{

using System.Data;

public static partial class Extensions
{
    /// <summary>
    ///     A ConnectionState extension method that insert.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool In(this ConnectionState @this, params ConnectionState[] values)
    {
        return values.IndexOf(@this) != -1;
    }
}

}