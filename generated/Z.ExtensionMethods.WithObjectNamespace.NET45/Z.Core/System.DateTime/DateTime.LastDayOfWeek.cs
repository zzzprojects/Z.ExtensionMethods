using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A DateTime extension method that last day of week.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A DateTime.</returns>
        public static DateTime LastDayOfWeek(this DateTime @this)
        {
            return new DateTime(@this.Year, @this.Month, @this.Day).AddDays(6 - (int) @this.DayOfWeek);
        }
    }


}