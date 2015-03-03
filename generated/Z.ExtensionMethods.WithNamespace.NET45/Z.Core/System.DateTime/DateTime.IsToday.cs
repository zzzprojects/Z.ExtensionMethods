using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A DateTime extension method that query if '@this' is today.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if today, false if not.</returns>
        public static bool IsToday(this DateTime @this)
        {
            return @this.Date == DateTime.Today;
        }
    }


}