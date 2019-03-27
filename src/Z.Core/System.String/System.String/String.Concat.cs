// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>
    ///     Concatenates two specified instances of .
    /// </summary>
    /// <param name="str0">The first string to concatenate.</param>
    /// <param name="str1">The second string to concatenate.</param>
    /// <returns>The concatenation of  and .</returns>
    public static String Concat(this String str0, String str1)
    {
        return String.Concat(str0, str1);
    }

    /// <summary>
    ///     Concatenates three specified instances of .
    /// </summary>
    /// <param name="str0">The first string to concatenate.</param>
    /// <param name="str1">The second string to concatenate.</param>
    /// <param name="str2">The third string to concatenate.</param>
    /// <returns>The concatenation of , , and .</returns>
    public static String Concat(this String str0, String str1, String str2)
    {
        return String.Concat(str0, str1, str2);
    }

    /// <summary>
    ///     Concatenates four specified instances of .
    /// </summary>
    /// <param name="str0">The first string to concatenate.</param>
    /// <param name="str1">The second string to concatenate.</param>
    /// <param name="str2">The third string to concatenate.</param>
    /// <param name="str3">The fourth string to concatenate.</param>
    /// <returns>The concatenation of , , , and .</returns>
    public static String Concat(this String str0, String str1, String str2, String str3)
    {
        return String.Concat(str0, str1, str2, str3);
    }
}