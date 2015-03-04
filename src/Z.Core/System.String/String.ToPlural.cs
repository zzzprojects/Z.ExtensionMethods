// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;

public static partial class Extensions
{
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
}