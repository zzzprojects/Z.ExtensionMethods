// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.Data.SqlServerCe;

public static partial class Extensions
{
    /// <summary>
    ///     A SqlParameterCollection extension method that adds a range with value to 'values'.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">The values.</param>
    public static void AddRangeWithValue(this SqlCeParameterCollection @this, Dictionary<string, object> values)
    {
        foreach (var keyValuePair in values)
        {
            @this.AddWithValue(keyValuePair.Key, keyValuePair.Value);
        }
    }
}