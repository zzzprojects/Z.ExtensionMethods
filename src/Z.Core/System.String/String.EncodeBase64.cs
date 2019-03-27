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
    ///     A string extension method that encode the string to Base64.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The encoded string to Base64.</returns>
    public static string EncodeBase64(this string @this)
    {
        return Convert.ToBase64String(Activator.CreateInstance<ASCIIEncoding>().GetBytes(@this));
    }
}