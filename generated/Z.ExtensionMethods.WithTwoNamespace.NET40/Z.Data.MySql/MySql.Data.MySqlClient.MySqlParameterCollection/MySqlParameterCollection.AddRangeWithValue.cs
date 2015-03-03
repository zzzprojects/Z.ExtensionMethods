using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System.Collections.Generic;
using MySql.Data.MySqlClient;

public static partial class Extensions
{
    /// <summary>
    ///     A MySqlParameterCollection extension method that adds a range with value to 'values'.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">The values.</param>
    public static void AddRangeWithValue(this MySqlParameterCollection @this, Dictionary<string, object> values)
    {
        foreach (var keyValuePair in values)
        {
            @this.AddWithValue(keyValuePair.Key, keyValuePair.Value);
        }
    }
}

}