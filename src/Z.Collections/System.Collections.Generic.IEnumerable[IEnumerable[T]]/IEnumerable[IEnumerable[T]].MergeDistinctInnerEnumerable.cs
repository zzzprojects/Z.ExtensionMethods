// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.Linq;

public static partial class Extensions
{
    /// <summary>Enumerates merge distinct inner enumerable in this collection.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>
    ///     An enumerator that allows foreach to be used to process merge distinct inner
    ///     enumerable in this collection.
    /// </returns>
    public static IEnumerable<T> MergeDistinctInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> @this)
    {
        List<IEnumerable<T>> listItem = @this.ToList();

        var list = new List<T>();

        foreach (var item in listItem)
        {
            list = list.Union(item).ToList();
        }

        return list;
    }
}