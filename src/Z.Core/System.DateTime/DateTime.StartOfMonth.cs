using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A DateTime extension method that return a DateTime of the first day of the month with the time set to
        ///     "00:00:00:000". The first moment of the first day of the month.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A DateTime of the first day of the month with the time set to "00:00:00:000".</returns>
        public static DateTime StartOfMonth(this DateTime @this)
        {
            return new DateTime(@this.Year, @this.Month, 1);
        }
    }
