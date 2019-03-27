// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Data;

public static partial class Extensions
{
    /// <summary>
    ///     An IDataReader extension method that applies an operation to all items in this collection.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="action">The action.</param>
    /// <returns>An IDataReader.</returns>
    public static IDataReader ForEach(this IDataReader @this, Action<IDataReader> action)
    {
        while (@this.Read())
        {
            action(@this);
        }

        return @this;
    }
}