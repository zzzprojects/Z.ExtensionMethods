// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that decode a Base64 String.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The Base64 String decoded.</returns>
    public static string DecodeBase64(this string @this)
    {
        return Encoding.ASCII.GetString(Convert.FromBase64String(@this));
    }
}