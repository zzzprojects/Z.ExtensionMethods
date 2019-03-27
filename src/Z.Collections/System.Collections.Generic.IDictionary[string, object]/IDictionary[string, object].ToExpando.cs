// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.Dynamic;

public static partial class Extensions
{
    /// <summary>
    ///     An IDictionary&lt;string,object&gt; extension method that converts the @this to an expando.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an ExpandoObject.</returns>
    public static ExpandoObject ToExpando(this IDictionary<string, object> @this)
    {
        var expando = new ExpandoObject();
        var expandoDict = (IDictionary<string, object>) expando;

        foreach (var item in @this)
        {
            if (item.Value is IDictionary<string, object>)
            {
                var d = (IDictionary<string, object>) item.Value;
                expandoDict.Add(item.Key, d.ToExpando());
            }
            else
            {
                expandoDict.Add(item);
            }
        }

        return expando;
    }
}