using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns the absolute value of a double-precision floating-point number.
        /// </summary>
        /// <param name="value">A number that is greater than or equal to , but less than or equal to .</param>
        /// <returns>A double-precision floating-point number, x, such that 0 ? x ?.</returns>
        public static Double Abs(this Double value)
        {
            return Math.Abs(value);
        }
    }


}