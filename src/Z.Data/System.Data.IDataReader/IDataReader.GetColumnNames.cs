// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Collections.Generic;
using System.Data;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     Gets the column names in this collection.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>An enumerator that allows foreach to be used to get the column names in this collection.</returns>
    public static IEnumerable<string> GetColumnNames(this IDataRecord @this)
    {
        return Enumerable.Range(0, @this.FieldCount)
            .Select(@this.GetName)
            .ToList();
    }
}