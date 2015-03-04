// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

public static partial class Extensions
{
    /// <summary>
    ///     A bool extension method that show the trueValue when the @this value is true; otherwise show the falseValue.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="trueValue">The true value to be returned if the @this value is true.</param>
    /// <param name="falseValue">The false value to be returned if the @this value is false.</param>
    /// <returns>A string that represents of the current boolean value.</returns>
    public static string ToString(this bool @this, string trueValue, string falseValue)
    {
        return @this ? trueValue : falseValue;
    }
}