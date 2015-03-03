using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns the absolute value of an 8-bit signed integer.
        /// </summary>
        /// <param name="value">A number that is greater than , but less than or equal to .</param>
        /// <returns>An 8-bit signed integer, x, such that 0 ? x ?.</returns>
        public static SByte Abs(this SByte value)
        {
            return Math.Abs(value);
        }
    }


}