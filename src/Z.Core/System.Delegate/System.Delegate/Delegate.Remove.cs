// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;

public static partial class Extensions
{
    /// <summary>
    ///     Removes the last occurrence of the invocation list of a delegate from the invocation list of another delegate.
    /// </summary>
    /// <param name="source">The delegate from which to remove the invocation list of .</param>
    /// <param name="value">The delegate that supplies the invocation list to remove from the invocation list of .</param>
    /// ###
    /// <returns>
    ///     A new delegate with an invocation list formed by taking the invocation list of  and removing the last
    ///     occurrence of the invocation list of , if the invocation list of  is found within the invocation list of .
    ///     Returns  if  is null or if the invocation list of  is not found within the invocation list of . Returns a
    ///     null reference if the invocation list of  is equal to the invocation list of  or if  is a null reference.
    /// </returns>
    public static Delegate Remove(this Delegate source, Delegate value)
    {
        return Delegate.Remove(source, value);
    }
}