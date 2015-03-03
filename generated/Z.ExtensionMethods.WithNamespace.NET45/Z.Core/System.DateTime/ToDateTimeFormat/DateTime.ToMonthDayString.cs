using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;
using System.Globalization;

public static partial class Extensions
    {
        /// <summary>
        ///     A DateTime extension method that converts this object to a month day string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToMonthDayString(this DateTime @this)
        {
            return @this.ToString("m", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        ///     A DateTime extension method that converts this object to a month day string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToMonthDayString(this DateTime @this, string culture)
        {
            return @this.ToString("m", new CultureInfo(culture));
        }

        /// <summary>
        ///     A DateTime extension method that converts this object to a month day string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToMonthDayString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("m", culture);
        }
    }


}