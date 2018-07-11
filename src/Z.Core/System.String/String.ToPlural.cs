// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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