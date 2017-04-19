// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Text;

public static partial class Extensions
{
    /// <summary>A StringBuilder extension method that gets index after next double quote.</summary>
    /// <param name="this">The path to act on.</param>
    /// <returns>The index after next double quote.</returns>
    public static int GetIndexAfterNextDoubleQuote(this StringBuilder @this)
    {
        return @this.GetIndexAfterNextDoubleQuote(0, false);
    }

    /// <summary>A StringBuilder extension method that gets index after next double quote.</summary>
    /// <param name="this">The path to act on.</param>
    /// <param name="allowEscape">true to allow, false to deny escape.</param>
    /// <returns>The index after next double quote.</returns>
    public static int GetIndexAfterNextDoubleQuote(this StringBuilder @this, bool allowEscape)
    {
        return @this.GetIndexAfterNextDoubleQuote(0, allowEscape);
    }

    /// <summary>A StringBuilder extension method that gets index after next double quote.</summary>
    /// <param name="this">The path to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The index after next double quote.</returns>
    public static int GetIndexAfterNextDoubleQuote(this StringBuilder @this, int startIndex)
    {
        return @this.GetIndexAfterNextDoubleQuote(startIndex, false);
    }

    /// <summary>A StringBuilder extension method that gets index after next double quote.</summary>
    /// <param name="this">The path to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="allowEscape">true to allow, false to deny escape.</param>
    /// <returns>The index after next double quote.</returns>
    public static int GetIndexAfterNextDoubleQuote(this StringBuilder @this, int startIndex, bool allowEscape)
    {
        while (startIndex < @this.Length)
        {
            char ch = @this[startIndex];
            startIndex++;

            char nextChar;
            if (allowEscape && ch == '\\' && startIndex < @this.Length && ((nextChar = @this[startIndex]) == '\\' || nextChar == '"'))
            {
                startIndex++; // Treat as escape character for \\ or \"
            }
            else if (ch == '"')
            {
                return startIndex;
            }
        }

        return startIndex;
    }
}