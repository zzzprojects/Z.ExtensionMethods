// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

public static partial class Extensions
{
    /// <summary>A string extension method that replaces.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="length">The length.</param>
    /// <param name="value">The value.</param>
    /// <returns>A string.</returns>
    public static string Replace(this string @this, int startIndex, int length, string value)
    {
        @this = @this.Remove(startIndex, length).Insert(startIndex, value);

        return @this;
    }
}