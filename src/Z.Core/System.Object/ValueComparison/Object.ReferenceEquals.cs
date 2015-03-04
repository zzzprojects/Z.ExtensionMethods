// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the specified  instances are the same instance.
    /// </summary>
    /// <param name="objA">The first object to compare.</param>
    /// <param name="objB">The second object  to compare.</param>
    /// <returns>true if  is the same instance as  or if both are null; otherwise, false.</returns>
    public static Boolean ReferenceEquals(this Object objA, Object objB)
    {
        return Object.ReferenceEquals(objA, objB);
    }
}