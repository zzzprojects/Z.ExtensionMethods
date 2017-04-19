// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Collections.Generic;
using System.Collections.Specialized;

public static partial class Extensions
{
    /// <summary>
    ///     An IDictionary&lt;string,string&gt; extension method that converts the @this to a name value collection.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a NameValueCollection.</returns>
    public static NameValueCollection ToNameValueCollection(this IDictionary<string, string> @this)
    {
        if (@this == null)
        {
            return null;
        }

        var col = new NameValueCollection();
        foreach (var item in @this)
        {
            col.Add(item.Key, item.Value);
        }
        return col;
    }
}