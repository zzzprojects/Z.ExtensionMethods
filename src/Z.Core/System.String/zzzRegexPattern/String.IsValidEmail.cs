// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Text.RegularExpressions;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that query if 'obj' is valid email.
    /// </summary>
    /// <param name="obj">The obj to act on.</param>
    /// <returns>true if valid email, false if not.</returns>
    public static bool IsValidEmail(this string obj)
    {
        return Regex.IsMatch(obj, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z0-9]{1,30})(\]?)$");
    }
}