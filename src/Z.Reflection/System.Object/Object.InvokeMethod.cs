// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Linq;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that executes the method on a different thread, and waits for the result.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="obj">The obj to act on.</param>
    /// <param name="methodName">Name of the method.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <returns>An object.</returns>
    public static object InvokeMethod<T>(this T obj, string methodName, params object[] parameters)
    {
        Type type = obj.GetType();
        MethodInfo method = type.GetMethod(methodName, parameters.Select(o => o.GetType()).ToArray());

        return method.Invoke(obj, parameters);
    }

    /// <summary>
    ///     An object extension method that executes the method on a different thread, and waits for the result.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="obj">The obj to act on.</param>
    /// <param name="methodName">Name of the method.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <returns>A T.</returns>
    public static T InvokeMethod<T>(this object obj, string methodName, params object[] parameters)
    {
        Type type = obj.GetType();
        MethodInfo method = type.GetMethod(methodName, parameters.Select(o => o.GetType()).ToArray());

        object value = method.Invoke(obj, parameters);
        return (value is T ? (T) value : default(T));
    }
}