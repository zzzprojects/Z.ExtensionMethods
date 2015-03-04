// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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