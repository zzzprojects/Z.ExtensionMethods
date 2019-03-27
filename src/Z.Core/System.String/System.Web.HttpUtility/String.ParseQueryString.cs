// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Collections.Specialized;
using System.Text;
using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     Parses a query string into a  using  encoding.
    /// </summary>
    /// <param name="query">The query string to parse.</param>
    /// <returns>A  of query parameters and values.</returns>
    public static NameValueCollection ParseQueryString(this String query)
    {
        return HttpUtility.ParseQueryString(query);
    }

    /// <summary>
    ///     Parses a query string into a  using the specified .
    /// </summary>
    /// <param name="query">The query string to parse.</param>
    /// <param name="encoding">The  to use.</param>
    /// <returns>A  of query parameters and values.</returns>
    public static NameValueCollection ParseQueryString(this String query, Encoding encoding)
    {
        return HttpUtility.ParseQueryString(query, encoding);
    }
}