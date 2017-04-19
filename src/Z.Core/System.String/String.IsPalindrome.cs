// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Linq;
using System.Text.RegularExpressions;

public static partial class Extensions
{
    /// <summary>A string extension method that query if '@this' is palindrome.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if palindrome, false if not.</returns>
    public static bool IsPalindrome(this string @this)
    {
        // Keep only alphanumeric characters

        var rgx = new Regex("[^a-zA-Z0-9]");
        @this = rgx.Replace(@this, "");
        return @this.SequenceEqual(@this.Reverse());
    }
}