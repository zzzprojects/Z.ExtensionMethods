using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;
using System.Globalization;

public static partial class Extensions
    {
        /// <summary>
        ///     A DateTime extension method that converts this object to a short date long time string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToShortDateLongTimeString(this DateTime @this)
        {
            return @this.ToString("G", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        ///     A DateTime extension method that converts this object to a short date long time string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToShortDateLongTimeString(this DateTime @this, string culture)
        {
            return @this.ToString("G", new CultureInfo(culture));
        }

        /// <summary>
        ///     A DateTime extension method that converts this object to a short date long time string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToShortDateLongTimeString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("G", culture);
        }
    }


}