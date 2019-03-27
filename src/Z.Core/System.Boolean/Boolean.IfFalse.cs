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
    ///     A bool extension method that execute an Action if the value is false.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="action">The action to execute.</param>
    public static void IfFalse(this bool @this, Action action)
    {
        if (!@this)
        {
            action();
        }
    }
}