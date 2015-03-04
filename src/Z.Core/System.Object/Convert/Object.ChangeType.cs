// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns an object of the specified type whose value is equivalent to the specified object.
    /// </summary>
    /// <param name="value">An object that implements the  interface.</param>
    /// <param name="typeCode">The type of object to return.</param>
    /// <returns>
    ///     An object whose underlying type is  and whose value is equivalent to .-or-A null reference (Nothing in Visual
    ///     Basic), if  is null and  is , , or .
    /// </returns>
    public static Object ChangeType(this Object value, TypeCode typeCode)
    {
        return Convert.ChangeType(value, typeCode);
    }

    /// <summary>
    ///     Returns an object of the specified type whose value is equivalent to the specified object. A parameter
    ///     supplies culture-specific formatting information.
    /// </summary>
    /// <param name="value">An object that implements the  interface.</param>
    /// <param name="typeCode">The type of object to return.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <returns>
    ///     An object whose underlying type is  and whose value is equivalent to .-or- A null reference (Nothing in
    ///     Visual Basic), if  is null and  is , , or .
    /// </returns>
    public static Object ChangeType(this Object value, TypeCode typeCode, IFormatProvider provider)
    {
        return Convert.ChangeType(value, typeCode, provider);
    }

    /// <summary>
    ///     Returns an object of the specified type and whose value is equivalent to the specified object.
    /// </summary>
    /// <param name="value">An object that implements the  interface.</param>
    /// <param name="conversionType">The type of object to return.</param>
    /// <returns>
    ///     An object whose type is  and whose value is equivalent to .-or-A null reference (Nothing in Visual Basic), if
    ///     is null and  is not a value type.
    /// </returns>
    public static Object ChangeType(this Object value, Type conversionType)
    {
        return Convert.ChangeType(value, conversionType);
    }

    /// <summary>
    ///     Returns an object of the specified type whose value is equivalent to the specified object. A parameter
    ///     supplies culture-specific formatting information.
    /// </summary>
    /// <param name="value">An object that implements the  interface.</param>
    /// <param name="conversionType">The type of object to return.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <returns>
    ///     An object whose type is  and whose value is equivalent to .-or- , if the  of  and  are equal.-or- A null
    ///     reference (Nothing in Visual Basic), if  is null and  is not a value type.
    /// </returns>
    public static Object ChangeType(this Object value, Type conversionType, IFormatProvider provider)
    {
        return Convert.ChangeType(value, conversionType, provider);
    }

    /// <summary>
    ///     Returns an object of the specified type and whose value is equivalent to the specified object.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="value">An object that implements the  interface.</param>
    /// <returns>
    ///     An object whose type is  and whose value is equivalent to .-or-A null reference (Nothing in Visual Basic), if
    ///     is null and  is not a value type.
    /// </returns>
    public static Object ChangeType<T>(this Object value)
    {
        return (T) Convert.ChangeType(value, typeof (T));
    }

    /// <summary>
    ///     Returns an object of the specified type whose value is equivalent to the specified object. A parameter
    ///     supplies culture-specific formatting information.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="value">An object that implements the  interface.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <returns>
    ///     An object whose type is  and whose value is equivalent to .-or- , if the  of  and  are equal.-or- A null
    ///     reference (Nothing in Visual Basic), if  is null and  is not a value type.
    /// </returns>
    public static Object ChangeType<T>(this Object value, IFormatProvider provider)
    {
        return (T) Convert.ChangeType(value, typeof (T), provider);
    }
}