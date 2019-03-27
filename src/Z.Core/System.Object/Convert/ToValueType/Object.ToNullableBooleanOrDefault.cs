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
    ///     An object extension method that converts this object to a nullable boolean or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a bool?</returns>
    public static bool? ToNullableBooleanOrDefault(this object @this)
    {
        try
        {
            if (@this == null || @this == DBNull.Value)
            {
                return null;
            }

            return Convert.ToBoolean(@this);
        }
        catch (Exception)
        {
            return default(bool);
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable boolean or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to a bool?</returns>
    public static bool? ToNullableBooleanOrDefault(this object @this, bool? defaultValue)
    {
        try
        {
            if (@this == null || @this == DBNull.Value)
            {
                return null;
            }

            return Convert.ToBoolean(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable boolean or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a bool?</returns>
    public static bool? ToNullableBooleanOrDefault(this object @this, Func<bool?> defaultValueFactory)
    {
        try
        {
            if (@this == null || @this == DBNull.Value)
            {
                return null;
            }

            return Convert.ToBoolean(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}