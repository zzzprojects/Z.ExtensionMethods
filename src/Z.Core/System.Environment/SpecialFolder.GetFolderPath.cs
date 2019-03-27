// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>An Environment.SpecialFolder extension method that gets folder path.</summary>
    /// <param name="this">this.</param>
    /// <returns>The folder path.</returns>
    public static string GetFolderPath(this Environment.SpecialFolder @this)
    {
        return Environment.GetFolderPath(@this);
    }

    /// <summary>An Environment.SpecialFolder extension method that gets folder path.</summary>
    /// <param name="this">this.</param>
    /// <param name="option">The option.</param>
    /// <returns>The folder path.</returns>
    public static string GetFolderPath(this Environment.SpecialFolder @this, Environment.SpecialFolderOption option)
    {
        return Environment.GetFolderPath(@this, option);
    }
}