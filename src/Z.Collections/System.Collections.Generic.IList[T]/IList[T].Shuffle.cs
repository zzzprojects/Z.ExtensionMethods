// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;

public static partial class Extensions
{
    private static readonly Random _random = new Random();

    /// <summary>
    /// An IList&lt;T&gt; extension method that shuffles items in a collection.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    public static void Shuffle<T>(this IList<T> @this)
    {
        int length = @this.Count;
        for (int i = 0; i < length; i++)
        {
            int randomIndex = i + _random.Next(length - i);
            T item = @this.ElementAt(randomIndex);
            @this[randomIndex] = @this[i];
            @this[i] = item;
        }
    }
}