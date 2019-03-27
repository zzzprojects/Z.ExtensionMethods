// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     An Assembly extension method that gets an attribute.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The attribute.</returns>
    public static T GetAttribute<T>(this Assembly @this) where T : Attribute
    {
        object[] configAttributes = Attribute.GetCustomAttributes(@this, typeof (T), false);

        if (configAttributes != null && configAttributes.Length > 0)
        {
            return (T) configAttributes[0];
        }

        return null;
    }
}