// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     An IDataReader extension method that converts the @this to an expando object.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a dynamic.</returns>
    public static dynamic ToExpandoObject(this IDataReader @this)
    {
        Dictionary<int, KeyValuePair<int, string>> columnNames = Enumerable.Range(0, @this.FieldCount)
            .Select(x => new KeyValuePair<int, string>(x, @this.GetName(x)))
            .ToDictionary(pair => pair.Key);

        dynamic entity = new ExpandoObject();
        var expandoDict = (IDictionary<string, object>) entity;

        Enumerable.Range(0, @this.FieldCount)
            .ToList()
            .ForEach(x => expandoDict.Add(columnNames[x].Value, @this[x]));

        return entity;
    }
}