// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A StringBuilder extension method that extracts the string double quote described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted string double quote.</returns>
    public static StringBuilder ExtractStringDoubleQuote(this StringBuilder @this)
    {
        return @this.ExtractStringDoubleQuote(0);
    }
    /// <summary>A StringBuilder extension method that extracts the string double quote described by
    /// @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted string double quote.</returns>
    public static StringBuilder ExtractStringDoubleQuote(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractStringDoubleQuote(0, out endIndex);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the string double quote described by
    ///     @this.
    /// </summary>
    /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The extracted string double quote.</returns>
    public static StringBuilder ExtractStringDoubleQuote(this StringBuilder @this, int startIndex)
    {
        int endIndex;
        return @this.ExtractStringDoubleQuote(startIndex, out endIndex);
    }
    /// <summary>A StringBuilder extension method that extracts the string double quote described by
    /// @this.</summary>
    /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted string double quote.</returns>
    public static StringBuilder ExtractStringDoubleQuote(this StringBuilder @this, int startIndex, out int endIndex)
    {
        var sb = new StringBuilder();

        if (@this.Length > startIndex + 1)
        {
            var ch1 = @this[startIndex];

            if (ch1 == '"')
            {
                // "my string"

                var pos = startIndex + 1;

                while (pos < @this.Length)
                {
                    var ch = @this[pos];
                    pos++;

                    char nextChar;
                    if (ch == '\\' && pos < @this.Length && ((nextChar = @this[pos]) == '\\' || nextChar == '"'))
                    {
                        sb.Append(nextChar);
                        pos++; // Treat as escape character for \\ or \"
                    }
                    else if (ch == '"')
                    {
                        endIndex = pos;
                        return sb;
                    }
                    else
                    {
                        sb.Append(ch);
                    }
                }

                throw new Exception("Unclosed string starting at position: " + startIndex);
            }
        }

        endIndex = -1;
        return null;
    }
}