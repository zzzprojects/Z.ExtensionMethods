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
    ///     Concatenates the invocation lists of two delegates.
    /// </summary>
    /// <param name="a">The delegate whose invocation list comes first.</param>
    /// <param name="b">The delegate whose invocation list comes last.</param>
    /// ###
    /// <returns>
    ///     A new delegate with an invocation list that concatenates the invocation lists of  and  in that order. Returns
    ///     if  is null, returns  if  is a null reference, and returns a null reference if both  and  are null references.
    /// </returns>
    public static Delegate Combine(this Delegate a, Delegate b)
    {
        return Delegate.Combine(a, b);
    }
}