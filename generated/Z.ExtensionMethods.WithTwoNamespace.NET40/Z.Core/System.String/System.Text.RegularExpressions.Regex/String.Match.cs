using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;
using System.Text.RegularExpressions;

public static partial class Extensions
    {
        /// <summary>
        ///     Searches the specified input string for the first occurrence of the specified regular expression.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <returns>An object that contains information about the match.</returns>
        public static Match Match(this String input, String pattern)
        {
            return Regex.Match(input, pattern);
        }

        /// <summary>
        ///     Searches the input string for the first occurrence of the specified regular expression, using the specified
        ///     matching options.
        /// </summary>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>An object that contains information about the match.</returns>
        public static Match Match(this String input, String pattern, RegexOptions options)
        {
            return Regex.Match(input, pattern, options);
        }
    }


}