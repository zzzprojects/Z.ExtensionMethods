// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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