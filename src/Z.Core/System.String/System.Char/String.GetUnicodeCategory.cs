// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Globalization;

public static partial class Extensions
{
    /// <summary>
    ///     Categorizes the character at the specified position in a specified string into a group identified by one of
    ///     the  values.
    /// </summary>
    /// <param name="s">A .</param>
    /// <param name="index">The character position in .</param>
    /// <returns>A  enumerated constant that identifies the group that contains the character at position  in .</returns>
    public static UnicodeCategory GetUnicodeCategory(this String s, Int32 index)
    {
        return Char.GetUnicodeCategory(s, index);
    }
}