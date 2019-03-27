// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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
