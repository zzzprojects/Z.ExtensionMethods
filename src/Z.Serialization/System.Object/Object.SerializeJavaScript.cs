// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
#if !NETSTANDARD
using System.Web.Script.Serialization;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     A T extension method that serialize java script.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A string.</returns>
    public static string SerializeJavaScript<T>(this T @this)
    {
        var serializer = new JavaScriptSerializer();
        return serializer.Serialize(@this);
    }
#endif
}