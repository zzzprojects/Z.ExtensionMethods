// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Text;

public static partial class Extensions
{
    /// <summary>A StringBuilder extension method that substrings.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>A string.</returns>
    public static string Substring(this StringBuilder @this, int startIndex)
    {
        return @this.ToString(startIndex, @this.Length - startIndex);
    }

    /// <summary>A StringBuilder extension method that substrings.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="length">The length.</param>
    /// <returns>A string.</returns>
    public static string Substring(this StringBuilder @this, int startIndex, int length)
    {
        return @this.ToString(startIndex, length);
    }
}