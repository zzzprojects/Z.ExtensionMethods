// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;

public static partial class Extensions
{
    /// <summary>A TType extension method that tries.</summary>
    /// <typeparam name="TType">Type of the type.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="tryFunction">The try function.</param>
    /// <returns>A TResult.</returns>
    public static TResult Try<TType, TResult>(this TType @this, Func<TType, TResult> tryFunction)
    {
        try
        {
            return tryFunction(@this);
        }
        catch
        {
            return default(TResult);
        }
    }

    /// <summary>A TType extension method that tries.</summary>
    /// <typeparam name="TType">Type of the type.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="tryFunction">The try function.</param>
    /// <param name="catchValue">The catch value.</param>
    /// <returns>A TResult.</returns>
    public static TResult Try<TType, TResult>(this TType @this, Func<TType, TResult> tryFunction, TResult catchValue)
    {
        try
        {
            return tryFunction(@this);
        }
        catch
        {
            return catchValue;
        }
    }

    /// <summary>A TType extension method that tries.</summary>
    /// <typeparam name="TType">Type of the type.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="tryFunction">The try function.</param>
    /// <param name="catchValueFactory">The catch value factory.</param>
    /// <returns>A TResult.</returns>
    public static TResult Try<TType, TResult>(this TType @this, Func<TType, TResult> tryFunction, Func<TType, TResult> catchValueFactory)
    {
        try
        {
            return tryFunction(@this);
        }
        catch
        {
            return catchValueFactory(@this);
        }
    }

    /// <summary>A TType extension method that tries.</summary>
    /// <typeparam name="TType">Type of the type.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="tryFunction">The try function.</param>
    /// <param name="result">[out] The result.</param>
    /// <returns>A TResult.</returns>
    public static bool Try<TType, TResult>(this TType @this, Func<TType, TResult> tryFunction, out TResult result)
    {
        try
        {
            result = tryFunction(@this);
            return true;
        }
        catch
        {
            result = default(TResult);
            return false;
        }
    }

    /// <summary>A TType extension method that tries.</summary>
    /// <typeparam name="TType">Type of the type.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="tryFunction">The try function.</param>
    /// <param name="catchValue">The catch value.</param>
    /// <param name="result">[out] The result.</param>
    /// <returns>A TResult.</returns>
    public static bool Try<TType, TResult>(this TType @this, Func<TType, TResult> tryFunction, TResult catchValue, out TResult result)
    {
        try
        {
            result = tryFunction(@this);
            return true;
        }
        catch
        {
            result = catchValue;
            return false;
        }
    }

    /// <summary>A TType extension method that tries.</summary>
    /// <typeparam name="TType">Type of the type.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="tryFunction">The try function.</param>
    /// <param name="catchValueFactory">The catch value factory.</param>
    /// <param name="result">[out] The result.</param>
    /// <returns>A TResult.</returns>
    public static bool Try<TType, TResult>(this TType @this, Func<TType, TResult> tryFunction, Func<TType, TResult> catchValueFactory, out TResult result)
    {
        try
        {
            result = tryFunction(@this);
            return true;
        }
        catch
        {
            result = catchValueFactory(@this);
            return false;
        }
    }

    /// <summary>A TType extension method that attempts to action from the given data.</summary>
    /// <typeparam name="TType">Type of the type.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="tryAction">The try action.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool Try<TType>(this TType @this, Action<TType> tryAction)
    {
        try
        {
            tryAction(@this);
            return true;
        }
        catch
        {
            return false;
        }
    }

    /// <summary>A TType extension method that attempts to action from the given data.</summary>
    /// <typeparam name="TType">Type of the type.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="tryAction">The try action.</param>
    /// <param name="catchAction">The catch action.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool Try<TType>(this TType @this, Action<TType> tryAction, Action<TType> catchAction)
    {
        try
        {
            tryAction(@this);
            return true;
        }
        catch
        {
            catchAction(@this);
            return false;
        }
    }
}