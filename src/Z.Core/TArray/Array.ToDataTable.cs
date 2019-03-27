// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Data;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     A T[] extension method that converts the @this to a data table.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a DataTable.</returns>
    public static DataTable ToDataTable<T>(this T[] @this)
    {
        Type type = typeof (T);

        PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

        var dt = new DataTable();

        foreach (PropertyInfo property in properties)
        {
            dt.Columns.Add(property.Name, property.PropertyType);
        }

        foreach (FieldInfo field in fields)
        {
            dt.Columns.Add(field.Name, field.FieldType);
        }

        foreach (T item in @this)
        {
            DataRow dr = dt.NewRow();

            foreach (PropertyInfo property in properties)
            {
                dr[property.Name] = property.GetValue(item, null);
            }

            foreach (FieldInfo field in fields)
            {
                dr[field.Name] = field.GetValue(item);
            }

            dt.Rows.Add(dr);
        }

        return dt;
    }
}