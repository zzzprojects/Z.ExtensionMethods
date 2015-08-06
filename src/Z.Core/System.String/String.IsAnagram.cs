﻿// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that query if '@this' is anagram.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="otherString">The @otherString[optional parameter] to act on.</param>
    /// <returns>true if anagram, false if not.</returns>
    public static bool IsAnagram(this string @this, string @otherString=null)
    {
        if (@otherString!=null)
        {
            return @this == @otherString.Reverse();
        }
        return @this == @this.Reverse();
    }
}
