// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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