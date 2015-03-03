using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

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


}