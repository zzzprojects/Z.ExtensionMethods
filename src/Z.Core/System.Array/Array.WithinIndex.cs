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
    ///     An Array extension method that check if the array is lower then the specified index.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="index">Zero-based index of the.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool WithinIndex(this Array @this, int index)
    {
        return index >= 0 && index < @this.Length;
    }

    /// <summary>
    ///     An Array extension method that check if the array is lower then the specified index.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="index">Zero-based index of the.</param>
    /// <param name="dimension">(Optional) the dimension.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool WithinIndex(this Array @this, int index, int dimension = 0)
    {
        return index >= @this.GetLowerBound(dimension) && index <= @this.GetUpperBound(dimension);
    }
}