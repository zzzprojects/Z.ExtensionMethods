// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>
    ///     Replaces the format item in a specified String with the text equivalent of the value of a corresponding
    ///     Object instance in a specified array.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="arg0">The argument 0.</param>
    /// <returns>
    ///     A copy of format in which the format items have been replaced by the String equivalent of the corresponding
    ///     instances of Object in args.
    /// </returns>
    public static String FormatWith(this String @this, Object arg0)
    {
        return String.Format(@this, arg0);
    }

    /// <summary>
    ///     Replaces the format item in a specified String with the text equivalent of the value of a corresponding
    ///     Object instance in a specified array.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="arg0">The argument 0.</param>
    /// <param name="arg1">The first argument.</param>
    /// <returns>
    ///     A copy of format in which the format items have been replaced by the String equivalent of the corresponding
    ///     instances of Object in args.
    /// </returns>
    public static String FormatWith(this String @this, Object arg0, Object arg1)
    {
        return String.Format(@this, arg0, arg1);
    }

    /// <summary>
    ///     Replaces the format item in a specified String with the text equivalent of the value of a corresponding
    ///     Object instance in a specified array.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="arg0">The argument 0.</param>
    /// <param name="arg1">The first argument.</param>
    /// <param name="arg2">The second argument.</param>
    /// <returns>
    ///     A copy of format in which the format items have been replaced by the String equivalent of the corresponding
    ///     instances of Object in args.
    /// </returns>
    public static String FormatWith(this String @this, Object arg0, Object arg1, Object arg2)
    {
        return String.Format(@this, arg0, arg1, arg2);
    }

    /// <summary>
    ///     Replaces the format item in a specified String with the text equivalent of the value of a corresponding
    ///     Object instance in a specified array.
    /// </summary>
    /// <param name="this">A String containing zero or more format items.</param>
    /// <param name="values">An Object array containing zero or more objects to format.</param>
    /// <returns>
    ///     A copy of format in which the format items have been replaced by the String equivalent of the corresponding
    ///     instances of Object in args.
    /// </returns>
    public static string FormatWith(this string @this, params object[] values)
    {
        return String.Format(@this, values);
    }
}