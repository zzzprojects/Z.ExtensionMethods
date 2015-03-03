namespace Z.ExtensionMethods
{

using System;
using System.Runtime.Caching;

public static partial class Extensions
{
    /// <summary>A MemoryCache extension method that adds an or get existing.</summary>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="cache">The cache to act on.</param>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <returns>A TValue.</returns>
    public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, TValue value)
    {
        object item = cache.AddOrGetExisting(key, value, new CacheItemPolicy()) ?? value;

        return (TValue) item;
    }

    /// <summary>A MemoryCache extension method that adds an or get existing.</summary>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="cache">The cache to act on.</param>
    /// <param name="key">The key.</param>
    /// <param name="valueFactory">The value factory.</param>
    /// <returns>A TValue.</returns>
    public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, Func<string, TValue> valueFactory)
    {
        var lazy = new Lazy<TValue>(() => valueFactory(key));

        Lazy<TValue> item = (Lazy<TValue>) cache.AddOrGetExisting(key, lazy, new CacheItemPolicy()) ?? lazy;

        return item.Value;
    }

    /// <summary>A MemoryCache extension method that adds an or get existing.</summary>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="cache">The cache to act on.</param>
    /// <param name="key">The key.</param>
    /// <param name="valueFactory">The value factory.</param>
    /// <param name="policy">The policy.</param>
    /// <param name="regionName">(Optional) name of the region.</param>
    /// <returns>A TValue.</returns>
    public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, Func<string, TValue> valueFactory, CacheItemPolicy policy, string regionName = null)
    {
        var lazy = new Lazy<TValue>(() => valueFactory(key));

        Lazy<TValue> item = (Lazy<TValue>) cache.AddOrGetExisting(key, lazy, policy, regionName) ?? lazy;

        return item.Value;
    }

    /// <summary>A MemoryCache extension method that adds an or get existing.</summary>
    /// <typeparam name="TValue">Type of the value.</typeparam>
    /// <param name="cache">The cache to act on.</param>
    /// <param name="key">The key.</param>
    /// <param name="valueFactory">The value factory.</param>
    /// <param name="absoluteExpiration">The policy.</param>
    /// <param name="regionName">(Optional) name of the region.</param>
    /// <returns>A TValue.</returns>
    public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, Func<string, TValue> valueFactory, DateTimeOffset absoluteExpiration, string regionName = null)
    {
        var lazy = new Lazy<TValue>(() => valueFactory(key));

        Lazy<TValue> item = (Lazy<TValue>) cache.AddOrGetExisting(key, lazy, absoluteExpiration, regionName) ?? lazy;

        return item.Value;
    }
}

}