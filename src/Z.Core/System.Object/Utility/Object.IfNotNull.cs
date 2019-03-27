// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>A T extension method that execute an action when the value is not null.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="action">The action.</param>
    public static void IfNotNull<T>(this T @this, Action<T> action) where T : class
    {
        if (@this != null)
        {
            action(@this);
        }
    }

    /// <summary>
    ///     A T extension method that the function result if not null otherwise default value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="func">The function.</param>
    /// <returns>The function result if @this is not null otherwise default value.</returns>
    public static TResult IfNotNull<T, TResult>(this T @this, Func<T, TResult> func) where T : class
    {
        return @this != null ? func(@this) : default(TResult);
    }

    /// <summary>
    ///     A T extension method that the function result if not null otherwise default value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="func">The function.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The function result if @this is not null otherwise default value.</returns>
    public static TResult IfNotNull<T, TResult>(this T @this, Func<T, TResult> func, TResult defaultValue) where T : class
    {
        return @this != null ? func(@this) : defaultValue;
    }

    /// <summary>
    ///     A T extension method that the function result if not null otherwise default value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="func">The function.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The function result if @this is not null otherwise default value.</returns>
    public static TResult IfNotNull<T, TResult>(this T @this, Func<T, TResult> func, Func<TResult> defaultValueFactory) where T : class
    {
        return @this != null ? func(@this) : defaultValueFactory();
    }
}