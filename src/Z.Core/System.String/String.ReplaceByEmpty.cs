// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that replace all values specified by an empty string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>A string with all specified values replaced by an empty string.</returns>
    public static string ReplaceByEmpty(this string @this, params string[] values)
    {
        foreach (string value in values)
        {
            @this = @this.Replace(value, "");
        }

        return @this;
    }
}