// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;

public static partial class Extensions
{
    /// <summary>
    ///     Replaces one or more format items in a specified string with the string representation of a specified object.
    /// </summary>
    /// <param name="format">A composite format string.</param>
    /// <param name="arg0">The object to format.</param>
    /// <returns>A copy of  in which any format items are replaced by the string representation of .</returns>
    public static String Format(this String format, Object arg0)
    {
        return String.Format(format, arg0);
    }

    /// <summary>
    ///     Replaces the format items in a specified string with the string representation of two specified objects.
    /// </summary>
    /// <param name="format">A composite format string.</param>
    /// <param name="arg0">The first object to format.</param>
    /// <param name="arg1">The second object to format.</param>
    /// <returns>A copy of  in which format items are replaced by the string representations of  and .</returns>
    public static String Format(this String format, Object arg0, Object arg1)
    {
        return String.Format(format, arg0, arg1);
    }

    /// <summary>
    ///     Replaces the format items in a specified string with the string representation of three specified objects.
    /// </summary>
    /// <param name="format">A composite format string.</param>
    /// <param name="arg0">The first object to format.</param>
    /// <param name="arg1">The second object to format.</param>
    /// <param name="arg2">The third object to format.</param>
    /// <returns>
    ///     A copy of  in which the format items have been replaced by the string representations of , , and .
    /// </returns>
    public static String Format(this String format, Object arg0, Object arg1, Object arg2)
    {
        return String.Format(format, arg0, arg1, arg2);
    }

    /// <summary>
    ///     Replaces the format item in a specified string with the string representation of a corresponding object in a
    ///     specified array.
    /// </summary>
    /// <param name="format">A composite format string.</param>
    /// <param name="args">An object array that contains zero or more objects to format.</param>
    /// <returns>
    ///     A copy of  in which the format items have been replaced by the string representation of the corresponding
    ///     objects in .
    /// </returns>
    public static String Format(this String format, Object[] args)
    {
        return String.Format(format, args);
    }
}