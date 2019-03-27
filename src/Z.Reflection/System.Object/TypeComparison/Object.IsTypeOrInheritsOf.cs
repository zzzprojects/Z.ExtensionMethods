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
    ///     A T extension method that query if '@this' is type or inherits of.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="type">The type.</param>
    /// <returns>true if type or inherits of, false if not.</returns>
    public static bool IsTypeOrInheritsOf<T>(this T @this, Type type)
    {
        Type objectType = @this.GetType();

        while (true)
        {
            if (objectType.Equals(type))
            {
                return true;
            }

            if ((objectType == objectType.BaseType) || (objectType.BaseType == null))
            {
                return false;
            }

            objectType = objectType.BaseType;
        }
    }
}