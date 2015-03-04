// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Collections.Generic;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>A T extension method that gets member paths.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="path">Full pathname of the file.</param>
    /// <returns>An array of member information.</returns>
    public static MemberInfo[] GetMemberPaths<T>(this T @this, string path)
    {
        Type lastType = @this.GetType();
        string[] paths = path.Split('.');

        var memberPaths = new List<MemberInfo>();

        foreach (string item in paths)
        {
            PropertyInfo propertyInfo = lastType.GetProperty(item);
            FieldInfo fieldInfo = lastType.GetField(item);

            if (propertyInfo != null)
            {
                memberPaths.Add(propertyInfo);
                lastType = propertyInfo.PropertyType;
            }
            if (fieldInfo != null)
            {
                memberPaths.Add(fieldInfo);
                lastType = fieldInfo.FieldType;
            }
        }

        return memberPaths.ToArray();
    }
}