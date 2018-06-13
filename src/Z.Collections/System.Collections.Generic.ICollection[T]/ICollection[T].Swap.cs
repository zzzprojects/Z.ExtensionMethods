// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// An ICollection&lt;T&gt; extension method that swaps value only when it exists in a collection.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="oldValue">The old value.</param>
    /// <param name="newValue">The new value.</param>
    /// <returns>
    /// true if it succeeds, false if it fails.
    /// </returns>
    public static ICollection<T> Swap<T>(this ICollection<T> @this, T oldValue, T newValue)
    {
        var collectionAsList = @this as IList<T>;

        if (collectionAsList != null)
        {
            var oldIndex = collectionAsList.IndexOf(oldValue);

            if(oldIndex < 0)
                return collectionAsList;

            collectionAsList.RemoveAt(oldIndex);
            collectionAsList.Insert(oldIndex, newValue);
            return collectionAsList;
        }

        @this.Remove(oldValue);
        @this.Add(newValue);
        return @this;
    }
}