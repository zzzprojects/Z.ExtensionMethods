// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the larger of two double-precision floating-point numbers.
    /// </summary>
    /// <param name="val1">The first of two double-precision floating-point numbers to compare.</param>
    /// <param name="val2">The second of two double-precision floating-point numbers to compare.</param>
    /// <returns>Parameter  or , whichever is larger. If , , or both  and  are equal to ,  is returned.</returns>
    public static Double Max(this Double val1, Double val2)
    {
        return Math.Max(val1, val2);
    }
}