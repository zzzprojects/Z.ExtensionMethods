// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Text.RegularExpressions;

public static partial class Extensions
{
    /// <summary>
    ///     Searches the specified input string for all occurrences of a specified regular expression.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="pattern">The regular expression pattern to match.</param>
    /// <returns>
    ///     A collection of the  objects found by the search. If no matches are found, the method returns an empty
    ///     collection object.
    /// </returns>
    public static MatchCollection Matches(this String input, String pattern)
    {
        return Regex.Matches(input, pattern);
    }

    /// <summary>
    ///     Searches the specified input string for all occurrences of a specified regular expression, using the
    ///     specified matching options.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="pattern">The regular expression pattern to match.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    /// <returns>
    ///     A collection of the  objects found by the search. If no matches are found, the method returns an empty
    ///     collection object.
    /// </returns>
    public static MatchCollection Matches(this String input, String pattern, RegexOptions options)
    {
        return Regex.Matches(input, pattern, options);
    }
}