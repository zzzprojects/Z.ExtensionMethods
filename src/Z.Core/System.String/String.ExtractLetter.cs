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
    ///     A string extension method that extracts the letter described by @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted letter.</returns>
    public static string ExtractLetter(this string @this)
    {
        return new string(@this.ToCharArray().Where(x => Char.IsLetter(x)).ToArray());
    }
}