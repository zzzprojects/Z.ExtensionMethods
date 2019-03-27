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
    ///     An object extension method that converts this object to a unique identifier or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a GUID.</returns>
    public static Guid ToGuidOrDefault(this object @this)
    {
        try
        {
            return new Guid(@this.ToString());
        }
        catch (Exception)
        {
            return Guid.Empty;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a unique identifier or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to a GUID.</returns>
    public static Guid ToGuidOrDefault(this object @this, Guid defaultValue)
    {
        try
        {
            return new Guid(@this.ToString());
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    /// An object extension method that converts this object to a unique identifier or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to a GUID.</returns>
    public static Guid ToGuidOrDefault(this object @this, Guid defaultValue, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null)
        {
            return defaultValue;
        }

        try
        {
            return new Guid(@this.ToString());
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a unique identifier or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a GUID.</returns>
    public static Guid ToGuidOrDefault(this object @this, Func<Guid> defaultValueFactory)
    {
        try
        {
            return new Guid(@this.ToString());
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }

    /// <summary>
    /// An object extension method that converts this object to a unique identifier or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to a GUID.</returns>
    public static Guid ToGuidOrDefault(this object @this, Func<Guid> defaultValueFactory, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null)
        {
            return defaultValueFactory();
        }

        try
        {
            return new Guid(@this.ToString());
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}