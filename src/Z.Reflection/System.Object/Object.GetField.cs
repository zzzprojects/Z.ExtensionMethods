// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Reflection;

public static partial class Extensions
{
    /// <summary>A T extension method that searches for the public field with the specified name.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="name">The string containing the name of the data field to get.</param>
    /// <returns>
    ///     An object representing the field that matches the specified requirements, if found;
    ///     otherwise, null.
    /// </returns>
    public static FieldInfo GetField<T>(this T @this, string name)
    {
        return @this.GetType().GetField(name);
    }

    /// <summary>
    ///     A T extension method that searches for the specified field, using the specified
    ///     binding constraints.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="name">The string containing the name of the data field to get.</param>
    /// <param name="bindingAttr">
    ///     A bitmask comprised of one or more BindingFlags that specify how the
    ///     search is conducted.
    /// </param>
    /// <returns>
    ///     An object representing the field that matches the specified requirements, if found;
    ///     otherwise, null.
    /// </returns>
    public static FieldInfo GetField<T>(this T @this, string name, BindingFlags bindingAttr)
    {
        return @this.GetType().GetField(name, bindingAttr);
    }
}