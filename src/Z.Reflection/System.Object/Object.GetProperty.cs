// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that gets a property.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="name">The name.</param>
    /// <returns>The property.</returns>
    public static PropertyInfo GetProperty<T>(this T @this, string name)
    {
        return @this.GetType().GetProperty(name);
    }

    /// <summary>
    ///     A T extension method that gets a property.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="name">The name.</param>
    /// <param name="bindingAttr">The binding attribute.</param>
    /// <returns>The property.</returns>
    public static PropertyInfo GetProperty<T>(this T @this, string name, BindingFlags bindingAttr)
    {
        return @this.GetType().GetProperty(name, bindingAttr);
    }
}