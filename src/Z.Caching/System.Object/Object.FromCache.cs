// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Linq.Expressions;
#if !NETSTANDARD
using System.Runtime.Caching;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>A TKey extension method that from cache.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cache">The cache.</param>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <returns>A TValue.</returns>
    public static TValue FromCache<T, TValue>(this T @this, MemoryCache cache, string key, TValue value)
    {
        object item = cache.AddOrGetExisting(key, value, new CacheItemPolicy()) ?? value;

        return (TValue) item;
    }

    /// <summary>A TKey extension method that from cache.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <returns>A TValue.</returns>
    public static TValue FromCache<T, TValue>(this T @this, string key, TValue value)
    {
        return @this.FromCache(MemoryCache.Default, key, value);
    }

    /// <summary>A TKey extension method that from cache.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cache">The cache.</param>
    /// <param name="key">The key.</param>
    /// <param name="valueFactory">The value factory.</param>
    /// <returns>A TValue.</returns>
    public static TValue FromCache<T, TValue>(this T @this, MemoryCache cache, string key, Expression<Func<T, TValue>> valueFactory)
    {
        var lazy = new Lazy<TValue>(() => valueFactory.Compile()(@this));
        Lazy<TValue> item = (Lazy<TValue>) cache.AddOrGetExisting(key, lazy, new CacheItemPolicy()) ?? lazy;
        return item.Value;
    }

    /// <summary>A TKey extension method that from cache.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="key">The key.</param>
    /// <param name="valueFactory">The value factory.</param>
    /// <returns>A TValue.</returns>
    public static TValue FromCache<T, TValue>(this T @this, string key, Expression<Func<T, TValue>> valueFactory)
    {
        return @this.FromCache(MemoryCache.Default, key, valueFactory);
    }

    /// <summary>A TKey extension method that from cache.</summary>
    /// <typeparam name="TKey">Type of the key.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="valueFactory">The value factory.</param>
    /// <returns>A TValue.</returns>
    public static TValue FromCache<TKey, TValue>(this TKey @this, Expression<Func<TKey, TValue>> valueFactory)
    {
        string key = string.Concat("Z.Caching.FromCache;", typeof (TKey).FullName, valueFactory.ToString());
        return @this.FromCache(MemoryCache.Default, key, valueFactory);
    }

    /// <summary>A TKey extension method that from cache.</summary>
    /// <typeparam name="TKey">Type of the key.</typeparam>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cache">The cache.</param>
    /// <param name="valueFactory">The value factory.</param>
    /// <returns>A TValue.</returns>
    public static TValue FromCache<TKey, TValue>(this TKey @this, MemoryCache cache, Expression<Func<TKey, TValue>> valueFactory)
    {
        string key = string.Concat("Z.Caching.FromCache;", typeof (TKey).FullName, valueFactory.ToString());
        return @this.FromCache(cache, key, valueFactory);
    }
#endif
}