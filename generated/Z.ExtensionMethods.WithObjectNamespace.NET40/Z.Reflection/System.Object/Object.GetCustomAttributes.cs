namespace Z.ExtensionMethods.ObjectExtensions
{

using System;

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that gets custom attributes.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>An array of object.</returns>
    public static object[] GetCustomAttributes(this object @this, bool inherit)
    {
        return @this.GetType().GetCustomAttributes(inherit);
    }

    /// <summary>
    ///     An object extension method that gets custom attributes.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>An array of object.</returns>
    public static object[] GetCustomAttributes<T>(this object @this, bool inherit) where T : Attribute
    {
        return @this.GetType().GetCustomAttributes(typeof (T), inherit);
    }
}

}