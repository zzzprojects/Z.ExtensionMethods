// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that cast anonymous type to the specified type.
    /// </summary>
    /// <typeparam name="T">Generic type parameter. The specified type.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The object as the specified type.</returns>
    public static T As<T>(this object @this)
    {
        return (T) @this;
    }
}