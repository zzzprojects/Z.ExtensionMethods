// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
#if !NETSTANDARD
using System.Web;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     Encodes a byte array into its equivalent string representation using base 64 digits, which is usable for
    ///     transmission on the URL.
    /// </summary>
    /// <param name="input">The byte array to encode.</param>
    /// <returns>
    ///     The string containing the encoded token if the byte array length is greater than one; otherwise, an empty
    ///     string (&quot;&quot;).
    /// </returns>
    public static String UrlTokenEncode(this Byte[] input)
    {
        return HttpServerUtility.UrlTokenEncode(input);
    }
#endif
}