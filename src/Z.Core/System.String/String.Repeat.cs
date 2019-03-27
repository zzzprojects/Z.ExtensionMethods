// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that repeats the string a specified number of times.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="repeatCount">Number of repeats.</param>
    /// <returns>The repeated string.</returns>
    public static string Repeat(this string @this, int repeatCount)
    {
        if (@this.Length == 1)
        {
            return new string(@this[0], repeatCount);
        }

        var sb = new StringBuilder(repeatCount*@this.Length);
        while (repeatCount-- > 0)
        {
            sb.Append(@this);
        }

        return sb.ToString();
    }
}