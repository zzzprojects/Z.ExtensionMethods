// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Collections.Generic;
using System.Linq;

public static partial class Extensions
{
    /// <summary>Enumerates merge inner enumerable in this collection.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>
    ///     An enumerator that allows foreach to be used to process merge inner enumerable in
    ///     this collection.
    /// </returns>
    public static IEnumerable<T> MergeInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> @this)
    {
        List<IEnumerable<T>> listItem = @this.ToList();

        var list = new List<T>();

        foreach (var item in listItem)
        {
            list.AddRange(item);
        }

        return list;
    }
}