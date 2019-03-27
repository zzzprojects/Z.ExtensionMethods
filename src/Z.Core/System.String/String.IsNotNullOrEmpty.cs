// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that queries if '@this' is not (null or empty).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if '@this' is not (null or empty), false if not.</returns>
    public static bool IsNotNullOrEmpty(this string @this)
    {
        return !string.IsNullOrEmpty(@this);
    }
}