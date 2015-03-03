using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A DateTime extension method that query if '@this' is in the future.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if the value is in the future, false if not.</returns>
        public static bool IsFuture(this DateTime @this)
        {
            return @this > DateTime.Now;
        }
    }


}