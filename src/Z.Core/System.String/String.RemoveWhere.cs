// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that removes the letter.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="predicate">The predicate.</param>
    /// <returns>A string.</returns>
    public static string RemoveWhere(this string @this, Func<char, bool> predicate)
    {
        return new string(@this.ToCharArray().Where(x => !predicate(x)).ToArray());
    }
}