using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns the largest integer less than or equal to the specified decimal number.
        /// </summary>
        /// <param name="d">A decimal number.</param>
        /// <returns>
        ///     The largest integer less than or equal to .  Note that the method returns an integral value of type .
        /// </returns>
        public static Decimal Floor(this Decimal d)
        {
            return Math.Floor(d);
        }
    }


}