namespace Z.ExtensionMethods.ObjectExtensions
{

using System;

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that query if '@this' is attribute defined.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="attributeType">Type of the attribute.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>true if attribute defined, false if not.</returns>
    public static bool IsAttributeDefined(this object @this, Type attributeType, bool inherit)
    {
        return @this.GetType().IsDefined(attributeType, inherit);
    }

    /// <summary>
    ///     An object extension method that query if '@this' is attribute defined.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>true if attribute defined, false if not.</returns>
    public static bool IsAttributeDefined<T>(this object @this, bool inherit) where T : Attribute
    {
        return @this.GetType().IsDefined(typeof (T), inherit);
    }
}

}