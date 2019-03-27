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
    ///     An object extension method that query if '@this' is valid System.DateTime.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid System.DateTime, false if not.</returns>
    public static bool IsValidDateTime(this object @this)
    {
        if (@this == null)
        {
            return true;
        }

        DateTime result;
        return DateTime.TryParse(@this.ToString(), out result);
    }
}