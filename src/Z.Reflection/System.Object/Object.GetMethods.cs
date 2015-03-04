// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that returns all the public methods of the current Type.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>
    ///     An array of MethodInfo objects representing all the public methods defined for the current Type. or An empty
    ///     array of type MethodInfo, if no public methods are defined for the current Type.
    /// </returns>
    public static MethodInfo[] GetMethods<T>(this T @this)
    {
        return @this.GetType().GetMethods();
    }

    /// <summary>
    ///     A T extension method that searches for the methods defined for the current Type, using the specified binding
    ///     constraints.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="bindingAttr">A bitmask comprised of one or more BindingFlags that specify how the search is conducted.</param>
    /// <returns>
    ///     An array of MethodInfo objects representing all methods defined for the current Type that match the specified
    ///     binding constraints. or An empty array of type MethodInfo, if no methods are defined for the current Type, or
    ///     if none of the defined methods match the binding constraints.
    /// </returns>
    public static MethodInfo[] GetMethods<T>(this T @this, BindingFlags bindingAttr)
    {
        return @this.GetType().GetMethods(bindingAttr);
    }
}