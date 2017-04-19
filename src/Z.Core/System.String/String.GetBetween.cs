// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that get the string between the two specified string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="before">The string before to search.</param>
    /// <param name="after">The string after to search.</param>
    /// <returns>The string between the two specified string.</returns>
    public static string GetBetween(this string @this, string before, string after)
    {
        int beforeStartIndex = @this.IndexOf(before);
        int startIndex = beforeStartIndex + before.Length;
        int afterStartIndex = @this.IndexOf(after, startIndex);

        if (beforeStartIndex == -1 || afterStartIndex == -1)
        {
            return "";
        }

        return @this.Substring(startIndex, afterStartIndex - startIndex);
    }
}