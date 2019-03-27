// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that if empty.
    /// </summary>
    /// <param name="value">The value to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>A string.</returns>
    public static string IfEmpty(this string value, string defaultValue)
    {
        return (value.IsNotEmpty() ? value : defaultValue);
    }
}