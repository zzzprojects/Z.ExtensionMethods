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
    /// <summary>A StringBuilder extension method that extracts the character described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted character.</returns>
    public static char ExtractChar(this StringBuilder @this)
    {
        return @this.ExtractChar(0);
    }

    /// <summary>A StringBuilder extension method that extracts the character described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted character.</returns>
    public static char ExtractChar(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractChar(0, out endIndex);
    }

    /// <summary>A StringBuilder extension method that extracts the character described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The extracted character.</returns>
    public static char ExtractChar(this StringBuilder @this, int startIndex)
    {
        int endIndex;
        return @this.ExtractChar(startIndex, out endIndex);
    }

    /// <summary>A StringBuilder extension method that extracts the character described by @this.</summary>
    /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted character.</returns>
    public static char ExtractChar(this StringBuilder @this, int startIndex, out int endIndex)
    {
        if (@this.Length > startIndex + 1)
        {
            var ch1 = @this[startIndex];
            var ch2 = @this[startIndex + 1];
            var ch3 = @this[startIndex + 2];

            if (ch1 == '\'' && ch3 == '\'')
            {
                endIndex = startIndex + 2;
                return ch2;
            }
        }

        throw new Exception("Invalid char at position: " + startIndex);
    }
}