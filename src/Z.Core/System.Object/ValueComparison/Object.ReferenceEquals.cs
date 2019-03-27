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