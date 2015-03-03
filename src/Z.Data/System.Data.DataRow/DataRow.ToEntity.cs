using System;
using System.Data;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     A DataRow extension method that converts the @this to the entities.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a T.</returns>
    public static T ToEntity<T>(this DataRow @this) where T : new()
    {
        Type type = typeof (T);
        PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

        var entity = new T();

        foreach (PropertyInfo property in properties)
        {
            if (@this.Table.Columns.Contains(property.Name))
            {
                Type valueType = property.PropertyType;
                property.SetValue(entity, @this[property.Name].To(valueType), null);
            }
        }

        foreach (FieldInfo field in fields)
        {
            if (@this.Table.Columns.Contains(field.Name))
            {
                Type valueType = field.FieldType;
                field.SetValue(entity, @this[field.Name].To(valueType));
            }
        }

        return entity;
    }
}