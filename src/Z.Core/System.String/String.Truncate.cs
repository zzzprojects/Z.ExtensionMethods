// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that truncates.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="maxLength">The maximum length.</param>
    /// <returns>A string.</returns>
    public static string Truncate(this string @this, int maxLength)
    {
        const string suffix = "...";

        if (@this == null || @this.Length <= maxLength)
        {
            return @this;
        }

        int strLength = maxLength - suffix.Length;
        return @this.Substring(0, strLength) + suffix;
    }

    /// <summary>
    ///     A string extension method that truncates.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="maxLength">The maximum length.</param>
    /// <param name="suffix">The suffix.</param>
    /// <returns>A string.</returns>
    public static string Truncate(this string @this, int maxLength, string suffix)
    {
        if (@this == null || @this.Length <= maxLength)
        {
            return @this;
        }

        int strLength = maxLength - suffix.Length;
        return @this.Substring(0, strLength) + suffix;
    }
}