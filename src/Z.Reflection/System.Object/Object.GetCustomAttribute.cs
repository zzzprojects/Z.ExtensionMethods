using System;

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that gets the first custom attribute.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="attribute">The attribute.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>The custom attribute.</returns>
    public static object GetCustomAttribute(this object @this, Type attribute, bool inherit)
    {
        return @this.GetType().GetCustomAttributes(attribute, inherit)[0];
    }

    /// <summary>
    ///     An object extension method that gets custom attribute.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>The custom attribute.</returns>
    public static T GetCustomAttribute<T>(this object @this, bool inherit) where T : Attribute
    {
        return (T) @this.GetType().GetCustomAttributes(typeof (T), inherit)[0];
    }
}