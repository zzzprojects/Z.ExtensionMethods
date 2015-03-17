// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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