// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>
    ///     Removes all occurrences of the invocation list of a delegate from the invocation list of another delegate.
    /// </summary>
    /// <param name="source">The delegate from which to remove the invocation list of .</param>
    /// <param name="value">The delegate that supplies the invocation list to remove from the invocation list of .</param>
    /// ###
    /// <returns>
    ///     A new delegate with an invocation list formed by taking the invocation list of  and removing all occurrences
    ///     of the invocation list of , if the invocation list of  is found within the invocation list of . Returns  if
    ///     is null or if the invocation list of  is not found within the invocation list of . Returns a null reference
    ///     if the invocation list of  is equal to the invocation list of , if  contains only a series of invocation
    ///     lists that are equal to the invocation list of , or if  is a null reference.
    /// </returns>
    public static Delegate RemoveAll(this Delegate source, Delegate value)
    {
        return Delegate.RemoveAll(source, value);
    }
}