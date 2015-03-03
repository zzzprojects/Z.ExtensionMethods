using System;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that sets field value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="fieldName">Name of the field.</param>
    /// <param name="value">The value.</param>
    public static void SetFieldValue<T>(this T @this, string fieldName, object value)
    {
        Type type = @this.GetType();
        FieldInfo field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
        field.SetValue(@this, value);
    }
}