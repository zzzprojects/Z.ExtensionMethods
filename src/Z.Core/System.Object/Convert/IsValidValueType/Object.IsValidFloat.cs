// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that query if '@this' is valid float.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid float, false if not.</returns>
    public static bool IsValidFloat(this object @this)
    {
        if (@this == null)
        {
            return true;
        }

        float result;
        return float.TryParse(@this.ToString(), out result);
    }
}