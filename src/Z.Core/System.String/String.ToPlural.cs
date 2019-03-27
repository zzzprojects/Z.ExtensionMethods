// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
#if !NETSTANDARD
using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     A string extension method that converts the @this to a plural.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a string.</returns>
    public static string ToPlural(this string @this)
    {
        return PluralizationService.CreateService(new CultureInfo("en-US")).Pluralize(@this);
    }

    /// <summary>
    ///     A string extension method that converts the @this to a plural.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cultureInfo">Information describing the culture.</param>
    /// <returns>@this as a string.</returns>
    public static string ToPlural(this string @this, CultureInfo cultureInfo)
    {
        return PluralizationService.CreateService(cultureInfo).Pluralize(@this);
    }
#endif
}