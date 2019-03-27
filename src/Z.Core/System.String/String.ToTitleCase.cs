// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Globalization;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that converts the @this to a title case.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a string.</returns>
    public static string ToTitleCase(this string @this)
    {
        return new CultureInfo("en-US").TextInfo.ToTitleCase(@this);
    }

    /// <summary>
    ///     A string extension method that converts the @this to a title case.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cultureInfo">Information describing the culture.</param>
    /// <returns>@this as a string.</returns>
    public static string ToTitleCase(this string @this, CultureInfo cultureInfo)
    {
        return cultureInfo.TextInfo.ToTitleCase(@this);
    }
}