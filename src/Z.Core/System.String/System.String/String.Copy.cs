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
    ///     Creates a new instance of  with the same value as a specified .
    /// </summary>
    /// <param name="str">The string to copy.</param>
    /// <returns>A new string with the same value as .</returns>
    public static String Copy(this String str)
    {
        return String.Copy(str);
    }
}