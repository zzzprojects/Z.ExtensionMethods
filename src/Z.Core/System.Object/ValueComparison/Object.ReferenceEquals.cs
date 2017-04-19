// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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