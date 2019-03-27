// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that converts this object to a boolean or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a bool.</returns>
    public static bool ToBooleanOrDefault(this object @this)
    {
        try
        {
            return Convert.ToBoolean(@this);
        }
        catch (Exception)
        {
            return default(bool);
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a boolean or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">true to default value.</param>
    /// <returns>The given data converted to a bool.</returns>
    public static bool ToBooleanOrDefault(this object @this, bool defaultValue)
    {
        try
        {
            return Convert.ToBoolean(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }
    /// <summary>
    /// An object extension method that converts this object to a boolean or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">true to default value.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to a bool.</returns>
    public static bool ToBooleanOrDefault(this object @this, bool defaultValue, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null)
        {
            return defaultValue;
        }

        try
        {
            return Convert.ToBoolean(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a boolean or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a bool.</returns>
    public static bool ToBooleanOrDefault(this object @this, Func<bool> defaultValueFactory)
    {
        try
        {
            return Convert.ToBoolean(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }

    /// <summary>
    /// An object extension method that converts this object to a boolean or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to a bool.</returns>
    public static bool ToBooleanOrDefault(this object @this, Func<bool> defaultValueFactory, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null)
        {
            return defaultValueFactory();
        }

        try
        {
            return Convert.ToBoolean(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}