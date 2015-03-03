using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     Enumerates to entities in this collection.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an IEnumerable&lt;T&gt;</returns>
    public static IEnumerable<T> ToEntities<T>(this DataTable @this) where T : new()
    {
        Type type = typeof (T);
        PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

        var list = new List<T>();

        foreach (DataRow dr in @this.Rows)
        {
            var entity = new T();

            foreach (PropertyInfo property in properties)
            {
                if (@this.Columns.Contains(property.Name))
                {
                    Type valueType = property.PropertyType;
                    property.SetValue(entity, dr[property.Name].To(valueType), null);
                }
            }

            foreach (FieldInfo field in fields)
            {
                if (@this.Columns.Contains(field.Name))
                {
                    Type valueType = field.FieldType;
                    field.SetValue(entity, dr[field.Name].To(valueType));
                }
            }

            list.Add(entity);
        }

        return list;
    }
}