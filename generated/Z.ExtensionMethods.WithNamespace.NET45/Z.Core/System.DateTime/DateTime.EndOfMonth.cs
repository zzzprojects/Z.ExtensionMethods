using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A DateTime extension method that return a DateTime of the last day of the month with the time set to
        ///     "23:59:59:999". The last moment of the last day of the month.  Use "DateTime2" column type in sql to keep the
        ///     precision.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A DateTime of the last day of the month with the time set to "23:59:59:999".</returns>
        public static DateTime EndOfMonth(this DateTime @this)
        {
            return new DateTime(@this.Year, @this.Month, 1).AddMonths(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
        }
    }


}