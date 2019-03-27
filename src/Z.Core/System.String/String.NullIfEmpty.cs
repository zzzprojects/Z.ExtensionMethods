// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that return null if the value is empty else the value.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>null if the value is empty, otherwise the value.</returns>
    public static string NullIfEmpty(this string @this)
    {
        return @this == "" ? null : @this;
    }
}