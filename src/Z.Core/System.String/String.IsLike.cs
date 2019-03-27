// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Text.RegularExpressions;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that query if '@this' satisfy the specified pattern.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="pattern">The pattern to use. Use '*' as wildcard string.</param>
    /// <returns>true if '@this' satisfy the specified pattern, false if not.</returns>
    public static bool IsLike(this string @this, string pattern)
    {
        // Turn the pattern into regex pattern, and match the whole string with ^$
        string regexPattern = "^" + Regex.Escape(pattern) + "$";

        // Escape special character ?, #, *, [], and [!]
        regexPattern = regexPattern.Replace(@"\[!", "[^")
            .Replace(@"\[", "[")
            .Replace(@"\]", "]")
            .Replace(@"\?", ".")
            .Replace(@"\*", ".*")
            .Replace(@"\#", @"\d");

        return Regex.IsMatch(@this, regexPattern);
    }
}