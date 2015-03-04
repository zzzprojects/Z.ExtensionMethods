// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that cast anonymous type to the specified type.
    /// </summary>
    /// <typeparam name="T">Generic type parameter. The specified type.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The object as the specified type.</returns>
    public static T As<T>(this object @this)
    {
        return (T) @this;
    }
}