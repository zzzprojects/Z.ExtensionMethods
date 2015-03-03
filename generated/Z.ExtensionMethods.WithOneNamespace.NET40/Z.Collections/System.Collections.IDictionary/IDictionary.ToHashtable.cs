namespace Z.ExtensionMethods
{

using System.Collections;

public static partial class Extensions
{
    /// <summary>
    ///     An IDictionary extension method that converts the @this to a hashtable.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a Hashtable.</returns>
    public static Hashtable ToHashtable(this IDictionary @this)
    {
        return new Hashtable(@this);
    }
}

}