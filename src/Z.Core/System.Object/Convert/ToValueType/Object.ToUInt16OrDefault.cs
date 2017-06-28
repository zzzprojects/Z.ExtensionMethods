// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright ?ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that converts this object to an u int 16 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to an ushort.</returns>
    public static ushort ToUInt16OrDefault(this object @this)
    {
        try
        {
            return Convert.ToUInt16(@this);
        }
        catch (Exception)
        {
            return default(ushort);
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to an u int 16 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to an ushort.</returns>
    public static ushort ToUInt16OrDefault(this object @this, ushort defaultValue)
    {
        try
        {
            return Convert.ToUInt16(@this ?? "");
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    /// An object extension method that converts this object to an u int 16 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to an ushort.</returns>
    public static ushort ToUInt16OrDefault(this object @this, ushort defaultValue, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null)
        {
            return defaultValue;
        }

        try
        {
            return Convert.ToUInt16(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to an u int 16 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to an ushort.</returns>
    public static ushort ToUInt16OrDefault(this object @this, Func<ushort> defaultValueFactory)
    {
        try
        {
            return Convert.ToUInt16(@this ?? "");
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }

    /// <summary>
    /// An object extension method that converts this object to an u int 16 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to an ushort.</returns>
    public static ushort ToUInt16OrDefault(this object @this, Func<ushort> defaultValueFactory, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null)
        {
            return defaultValueFactory();
        }

        try
        {
            return Convert.ToUInt16(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}