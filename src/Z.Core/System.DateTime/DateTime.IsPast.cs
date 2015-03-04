// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that query if '@this' is in the past.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if the value is in the past, false if not.</returns>
    public static bool IsPast(this DateTime @this)
    {
        return @this < DateTime.Now;
    }
}