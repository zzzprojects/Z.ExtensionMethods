using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System.Data;

public static partial class Extensions
{
    /// <summary>
    ///     A ConnectionState extension method that not in.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool NotIn(this ConnectionState @this, params ConnectionState[] values)
    {
        return values.IndexOf(@this) == -1;
    }
}

}