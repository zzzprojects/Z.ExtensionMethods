using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns the absolute value of a 64-bit signed integer.
        /// </summary>
        /// <param name="value">A number that is greater than , but less than or equal to .</param>
        /// <returns>A 64-bit signed integer, x, such that 0 ? x ?.</returns>
        public static Int64 Abs(this Int64 value)
        {
            return Math.Abs(value);
        }
    }
