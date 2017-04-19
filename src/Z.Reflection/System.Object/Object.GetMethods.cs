// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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