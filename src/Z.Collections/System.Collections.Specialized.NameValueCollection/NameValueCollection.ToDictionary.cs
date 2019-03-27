// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.Collections.Specialized;

public static partial class Extensions
{
    /// <summary>
    ///     A NameValueCollection extension method that converts the @this to a dictionary.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an IDictionary&lt;string,object&gt;</returns>
    public static IDictionary<string, object> ToDictionary(this NameValueCollection @this)
    {
        var dict = new Dictionary<string, object>();

        if (@this != null)
        {
            foreach (string key in @this.AllKeys)
            {
                dict.Add(key, @this[key]);
            }
        }

        return dict;
    }
}