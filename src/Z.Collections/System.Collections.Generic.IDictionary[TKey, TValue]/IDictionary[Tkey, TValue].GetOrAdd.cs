// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    ///     Adds a key/value pair to the IDictionary&lt;TKey, TValue&gt; if the key does not already exist.
    /// </summary>
    /// <typeparam name="TKey">Type of the key.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="key">The key of the element to add.</param>
    /// <param name="value">The value to be added, if the key does not already exist.</param>
    /// <returns>
    ///     The value for the key. This will be either the existing value for the key if the key is already in the
    ///     dictionary, or the new value if the key was not in the dictionary.
    /// </returns>
    public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue value)
    {
        if (!@this.ContainsKey(key))
        {
            @this.Add(new KeyValuePair<TKey, TValue>(key, value));
        }

        return @this[key];
    }

    /// <summary>
    ///     Adds a key/value pair to the IDictionary&lt;TKey, TValue&gt; by using the specified function, if the key does
    ///     not already exist.
    /// </summary>
    /// <typeparam name="TKey">Type of the key.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="key">The key of the element to add.</param>
    /// <param name="valueFactory">TThe function used to generate a value for the key.</param>
    /// <returns>
    ///     The value for the key. This will be either the existing value for the key if the key is already in the
    ///     dictionary, or the new value for the key as returned by valueFactory if the key was not in the dictionary.
    /// </returns>
    public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, Func<TKey, TValue> valueFactory)
    {
        if (!@this.ContainsKey(key))
        {
            @this.Add(new KeyValuePair<TKey, TValue>(key, valueFactory(key)));
        }

        return @this[key];
    }
}