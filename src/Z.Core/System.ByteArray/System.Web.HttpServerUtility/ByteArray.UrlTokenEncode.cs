// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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