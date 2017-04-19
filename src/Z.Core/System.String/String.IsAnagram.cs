// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that query if '@this' is anagram of other String.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="otherString">The other string</param>
    /// <returns>true if the @this is anagram of the otherString, false if not.</returns>
    public static bool IsAnagram(this string @this, string otherString)
    {
        return @this
            .OrderBy(c => c)
            .SequenceEqual(otherString.OrderBy(c => c));
    }
}
