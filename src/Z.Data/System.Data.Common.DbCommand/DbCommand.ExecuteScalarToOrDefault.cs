// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Data.Common;

public static partial class Extensions
{
    /// <summary>
    ///     A DbCommand extension method that executes the scalar to or default operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A T.</returns>
    public static T ExecuteScalarToOrDefault<T>(this DbCommand @this)
    {
        try
        {
            return @this.ExecuteScalar().To<T>();
        }
        catch (Exception)
        {
            return default(T);
        }
    }

    /// <summary>
    ///     A DbCommand extension method that executes the scalar to or default operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>A T.</returns>
    public static T ExecuteScalarToOrDefault<T>(this DbCommand @this, T defaultValue)
    {
        try
        {
            return @this.ExecuteScalar().To<T>();
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     A DbCommand extension method that executes the scalar to or default operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>A T.</returns>
    public static T ExecuteScalarToOrDefault<T>(this DbCommand @this, Func<DbCommand, T> defaultValueFactory)
    {
        try
        {
            return @this.ExecuteScalar().To<T>();
        }
        catch (Exception)
        {
            return defaultValueFactory(@this);
        }
    }
}