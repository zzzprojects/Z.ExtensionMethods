using System;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that gets property value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="propertyName">Name of the property.</param>
    /// <returns>The property value.</returns>
    public static object GetPropertyValue<T>(this T @this, string propertyName)
    {
        Type type = @this.GetType();
        PropertyInfo property = type.GetProperty(propertyName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

        return property.GetValue(@this, null);
    }
}