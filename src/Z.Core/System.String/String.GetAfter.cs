// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that get the string after the specified string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="value">The value to search.</param>
    /// <returns>The string after the specified value.</returns>
    public static string GetAfter(this string @this, string value)
    {
        if (@this.IndexOf(value) == -1)
        {
            return "";
        }
        return @this.Substring(@this.IndexOf(value) + value.Length);
    }
}